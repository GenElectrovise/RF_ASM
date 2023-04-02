﻿using Crimson.CSharp.Exceptions;
using Crimson.CSharp.Parsing;
using Crimson.CSharp.Parsing.Statements;
using NLog;
using System.Text.RegularExpressions;

namespace Crimson.CSharp.Core
{
    /// <summary>
    /// A collection of CompilationUnit keyed with their absolute path within the file system.
    /// This is the result of parsing.
    /// The next stage is linking.
    /// 
    /// For example: <"C:/main.crm", CompilationUnit>.
    /// </summary>
    public class Compilation
    {
        private static readonly Logger LOGGER = LogManager.GetCurrentClassLogger();


        /// <summary>
        /// A library of all of the CompilationUnits used in this Compilation
        /// </summary>
        internal Library Library { get; }

        public Compilation (Library library)
        {
            Library = library;
        }

        public override string ToString ()
        {
            return $"Compilation(RootUnit={Library.Root}; Library={Library})";
        }

        public FunctionCStatement GetEntryFunction ()
        {
            string baseName = Core.Crimson.Options.EntryFunctionName;
            Scope rootUnit = Library.Root!;
            string pattern = $"^func_{baseName}_[0-9]+$"; //  Match name_090923 (anchored to start and end)
            Regex regex = new Regex(pattern);

            IList<FunctionCStatement> funcs = rootUnit.Functions.Values.Where(func => regex.IsMatch(func.Name.ToString())).ToList();
            if (funcs.Count == 0)
            {
                throw new FlatteningException($"No valid entry function found. Invalid contenders were: [{string.Join(',', rootUnit.Functions.Values.Select(f => f.Name))}]. Searched for Crimson name '{Core.Crimson.Options.EntryFunctionName}' using Regex: '{pattern}'.");
            }
            else if (funcs.Count == 1)
            {
                FunctionCStatement entry = funcs.Single();
                return entry;
            }
            else if (funcs.Count > 1)
            {
                throw new FlatteningException($"Cannot determine correct entry function. Found {funcs.Count} valid contenders: [{string.Join(',', funcs.Select(f => f.Name))}].");
            }
            else
            {
                throw new FlatteningException($"Congratulations, you've managed to find a very strange number of entry functions: {funcs.Count}");
            }
        }
    }
}