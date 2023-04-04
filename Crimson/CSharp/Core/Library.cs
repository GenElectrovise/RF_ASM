﻿using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Net;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Crimson.AntlrBuild;
using Crimson.CSharp.Exceptions;
using Crimson.CSharp.Parsing;
using NLog;

namespace Crimson.CSharp.Core
{
    /// <summary>
    /// Generates CompilationUnits from input text with the power of ANTLR.
    /// </summary>
    public class Library
    {
        private static readonly Logger LOGGER = LogManager.GetCurrentClassLogger();

        public static readonly string NATIVE_HOST = "native.crimson";
        public static readonly string ROOT_HOST = "root.crimson";

        /// <summary>
        /// The "master" list of units. Stored so that each unique unit is only created once.
        /// 
        /// For example:
        /// [ C:/utils.crm => UTILS_UNIT ]
        /// [ C:/main.crm  => MAIN_UNIT  ]
        /// </summary>
        private ConcurrentDictionary<Uri, Task<Scope>> Scopes { get; }

        public Scope Root { get; set; }

        public Library ()
        {
            Scopes = new ConcurrentDictionary<Uri, Task<Scope>>();
        }


        // ========== API ==========

        public Scope? GetScope (Uri uri)
        {
            if (Scopes.ContainsKey(uri))
            {
                return GetScopeUnsafe(uri);
            }
            else
            {
                Uri nativePath = SquashUri(uri);
                if (Scopes.ContainsKey(nativePath))
                {
                    return GetScopeUnsafe(nativePath);
                }
            }
            return null;
        }

        public List<Scope> GetScopes ()
        {
            List<Scope> scopes = new List<Scope>();

            foreach (var pair in Scopes)
            {
                Task<Scope> task = pair.Value;

                // TODO Key non-null, task null here
                if (task.Status == TaskStatus.Created)
                    task.Start();

                if (!task.IsCompleted)
                {
                    // TODO freezing here
                    LOGGER.Debug("Waiting for async loading to finish before returning scope list...");
                    task.Wait();
                }

                scopes.Add(pair.Value.Result!);
            }

            return scopes;
        }

        public void SetRootScope (Scope scope)
        {
            if (Root != null)
                LOGGER.Warn($"Overriding root scope {Root} with {scope}");
            else
                LOGGER.Info($"Setting root scope to {scope}");

            Root = scope;
        }

        public async Task<Scope> LoadScope (Uri uri)
        {
            LOGGER.Info($"Loading scope from {uri}");

            Stream source = await GetStreamOf(uri);
            StreamReader reader = new StreamReader(source);
            string text = reader.ReadToEnd();

            Scope scope = ParseScopeText(uri, text);

            LoadScopeDependencies(scope);

            // Only runs once (for root)
            if (Root == null)
            {
                SetRootScope(scope);

                bool waiting;
                do
                {
                    List<string> waitingList = new List<string>();
                    foreach (var pair in Scopes)
                    {
                        if (pair.Value == null) waitingList.Add(pair.Key.ToString());
                    }

                    waiting = waitingList.Count > 0;

                    if (waiting)
                    {
                        LOGGER.Info($"Waiting for: {String.Join(',', waitingList)}");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        LOGGER.Info($"Finished loading root scope!");
                    }

                } while (waiting);
            }

            return scope;
        }

        private async Task<Task<Scope>> LoadScopeAsync (Uri uri)
        {
            // Check if already loading/loaded and reserve key if not
            if (Scopes.ContainsKey(uri)) return Scopes[uri];
            Scopes[uri] = null!;

            // Generate task
            Task<Scope> task = await Task.Factory.StartNew(async () =>
            {
                Thread.CurrentThread.Name = $"{Thread.CurrentThread.Name}_{uri.ToString()}";
                return await LoadScope(uri);
            });

            // Assign correct non-null task to key
            Scopes[uri] = task;
            return task;
        }

        public override string ToString ()
        {
            return $"Library(Units:[{String.Join(',', Scopes.Select(u => u.Key))}])";
        }


        // ========== INTERNALS ==========


        private Scope GetScopeUnsafe (Uri uri)
        {
            Task<Scope> task = Scopes[uri];
            if (!task.IsCompleted)
            {
                LOGGER.Debug($"Waiting for scope {uri} to finish loading...");
                task.Wait();
            }
            return task.Result;
        }

        /// <summary>
        /// Loads dependencies for the given root CompilationUnit, as well as that unit's dependencies, recursively.
        /// Also checks for nested scopes and loads them as well!
        /// </summary>
        /// <param name="root"></param>
        private async void LoadScopeDependencies (Scope root)
        {
            LOGGER.Info($"Loading dependencies of {root}");
            List<Task> ongoingLoadingTasks = new List<Task>();

            // Load each imported scope
            // Queue loading of its dependencies (once it's loaded)
            foreach (var i in root.Imports)
            {
                if (Scopes.ContainsKey(i.Value.URI))
                {
                    LOGGER.Debug($"Skipping duplicate loading of {i.Value.URI}");
                    continue;
                }
                LOGGER.Debug($"Trying to load {i.Value.URI}");

                Task<Scope> scope = await LoadScopeAsync(i.Value.URI);
                Task dependencyTask = scope.ContinueWith(finishedTask => LoadScopeDependencies(finishedTask.Result));

                ongoingLoadingTasks.Add(dependencyTask);
            }

            // Check for imports in nested scopes
            foreach (var del in root.Delegates)
            {
                if (del.Invoke() is IHasScope hasScope)
                {
                    LoadScopeDependencies(hasScope.GetScope());
                }
            }

            // Wait for multithreading to finish before returning.
            /*foreach (var task in ongoingLoadingTasks)
            {
                try
                {
                    task.Wait();
                }
                catch (Exception)
                {
                    throw;
                }
            }*/
            LOGGER.Error(" ! NOT WAITING FOR DEPENDENCY LOADING TO FINISH ! ");
            LOGGER.Debug($"Finished loading dependencies of {root}");
        }

        private Scope ParseScopeText (Uri source, string textIn)
        {
            try
            {
                LOGGER.Debug($"Parsing {textIn.Length} characters from {source} with ANTLR...");

                // Get Antlr context
                AntlrInputStream a4is = new AntlrInputStream(textIn);
                CrimsonLexer lexer = new CrimsonLexer(a4is);
                CommonTokenStream cts = new CommonTokenStream(lexer);
                CrimsonParser parser = new CrimsonParser(cts);

                string sourceName = $"{source}";

                lexer.AddErrorListener(new LexerErrorListener(sourceName));
                parser.ErrorHandler = new ParserErrorStrategy(sourceName);

                CrimsonParser.ScopeContext cuCtx = parser.scope();
                ScopeVisitor visitor = new ScopeVisitor();
                Scope scope = visitor.VisitScope(cuCtx);

                scope.Uri = source;

                return scope;
            }
            catch (Exception ex)
            {
                Crimson.Panic($"An error ocurred while parsing a scope originating from {source}", Crimson.PanicCode.PARSE_SCOPE, ex);
                throw;
            }
        }

        private async Task<Stream> GetStreamOf (Uri uri)
        {
            try
            {
                if (uri.Scheme == Uri.UriSchemeFile)
                {
                    return File.OpenRead(uri.LocalPath);
                }

                else if (uri.Scheme == Uri.UriSchemeHttp)
                {

                    // New HTTP stuff
                    HttpClient client = new HttpClient();
                    HttpResponseMessage httpResponse = await client.GetAsync(uri);
                    return httpResponse.Content.ReadAsStream();
                }

                else
                {
                    throw new UriSchemeException(uri);
                }
            }
            catch (Exception e)
            {
                Crimson.Panic($"An error occurred getting the stream of the resource at the URI {uri}", Crimson.PanicCode.PARSE, e);
                throw;
            }
        }

        private Uri SquashUri (Uri uri)
        {
            UriBuilder builder = new UriBuilder(uri);

            if (uri.Scheme != Uri.UriSchemeFile)
                throw new UriFormatException($"Crimson only accepts URIs of the file:/// scheme at this time. Found: {uri.Scheme}");

            // file:///native.crimson/heap.crm
            if (uri.Host.Equals(NATIVE_HOST))
            {
                string localPath = $"{Crimson.Options.NativeUri.AbsolutePath}/{uri.AbsolutePath}";
                builder.Host = "";
                builder.Path = localPath;
            }

            // file://root.crimson/heap.crm
            if (uri.Host.Equals(ROOT_HOST))
            {
                string? parentDirectory = Path.GetDirectoryName(Crimson.Options.SourceUri.AbsolutePath);
                string localPath = $"{parentDirectory}/{uri.AbsolutePath}";
                builder.Host = "";
                builder.Path = localPath;
            }

            // file://C:/Crimson/Native%20Library/root.crimson/heap.crm or whatever
            return builder.Uri;
        }
    }
}
