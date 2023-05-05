﻿using Compiler.Generalising;
using Compiler.Generalising.Structures;
using CrimsonCore.Linking;

namespace Compiler.Parsing.Statements
{
    internal class BasicCallCStatement : AbstractCrimsonStatement
    {
        public string AssemblyText { get; protected set; }

        public BasicCallCStatement (string assemblyText)
        {
            AssemblyText = assemblyText;
        }
        public override void Link (LinkingContext ctx)
        {
            Linked = true;
        }

        public override IGeneralAssemblyStructure Generalise (GeneralisationContext context)
        {
            ArbitraryAssemblyStructure structure = new ArbitraryAssemblyStructure(AssemblyText);
            return structure;
        }
    }
}