﻿using CrimsonCore.Generalising;

namespace CrimsonCore.Generalising.Structures
{
    public class EmptyAssemblyStructure : IGeneralAssemblyStructure
    {
        public EmptyAssemblyStructure ()
        {
        }

        public IEnumerable<IGeneralAssemblyStructure> GetSubStructures ()
        {
            return Enumerable.Empty<IGeneralAssemblyStructure>();
        }

        public override string ToString ()
        {
            return "";
        }
    }
}