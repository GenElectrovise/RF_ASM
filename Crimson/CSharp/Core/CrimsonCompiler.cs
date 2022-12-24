﻿using Antlr4.Runtime;
using Crimson.AntlrBuild;
using Crimson.CSharp.Statements;
using NLog;

namespace Crimson.CSharp.Core
{
    /// <summary>
    /// The root of all compilation. Initiates and delegates tasks for the compilation process.
    /// </summary>
    internal class CrimsonCompiler
    {
        private static Logger LOGGER;
        public CrimsonCmdArguments Options { get; }
        public UnitGenerator UnitGenerator { get; }
        public Linker Linker { get; }

        public CrimsonCompiler(CrimsonCmdArguments options, UnitGenerator unitGenerator, Linker linker)
        {
            Options = options;
            UnitGenerator = unitGenerator;
            Linker = linker;
        }

        public int FullyCompileFromOptions()
        {
            CompilationUnit unit = UnitGenerator.GetUnitFromPath(Options.CompilationSourcePath);
            LinkedUnit compilation = Linker.Link(unit);
            return 1;
        }

    }
}
