﻿namespace Crimson.CSharp.Generalising.Structures
{
    internal class ScopeAssemblyStructure : IGeneralAssemblyStructure
    {
        public List<IGeneralAssemblyStructure> Structures { get; private set; }

        public ScopeAssemblyStructure ()
        {
            Structures = new List<IGeneralAssemblyStructure>();
        }

        internal void AddSubStructure (IGeneralAssemblyStructure labelAssemblyStructure)
        {
            Structures.Add(labelAssemblyStructure);
        }

        IEnumerable<IGeneralAssemblyStructure> IGeneralAssemblyStructure.GetSubStructures ()
        {
            return Structures;
        }

        public override string ToString ()
        {
            return $"SCP: " +
                $"\n {String.Join("\n    ", Structures)}";
        }
    }
}