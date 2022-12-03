﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crimson.CSharp.Reflection
{
    internal class CompilationUnit
    {
        private IList<Import> imports = new List<Import>();

        public void AddImport(Import import)
        {
            imports.Add(import);
        }
    }
}
