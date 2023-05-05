﻿using CrimsonCore.Parsing.Statements;
using NLog;
using CrimsonCore.Parsing;
using CrimsonCore.Core;

namespace CrimsonCore.Linking
{
    /// <summary>
    /// Converts a CompilationUnit to a LinkedUnit.
    /// </summary>
    internal class Linker
    {
        private static readonly Logger LOGGER = LogManager.GetCurrentClassLogger();

        // TODO Linking must include renaming functions/variables and reach down to identifiers simple values etc.

        /// <summary>
        /// Links the FunctionCalls in a Compilation.
        /// </summary>
        /// <param name="compilation"></param>
        public async Task Link (Compilation compilation)
        {
            LOGGER.Info("Linking compilation " + compilation);

            // Iterate through each relevant unit
            foreach (Scope scope in await compilation.Library.GetScopes())
            {
                LOGGER.Info("Linking " + scope);

                // Generate linking context for the current unit (based on the aliases of imports)
                // This means mapping "ALIAS" to "UNIT" so that each statement can remap itself
                LinkingContext ctx = new LinkingContext(scope, new Dictionary<string, Scope>(), compilation);

                // Add links from the current unit
                scope.Link(ctx);

                // Just so that I can put a breakpoint here
                continue;
            }

            return;
        }
    }
}