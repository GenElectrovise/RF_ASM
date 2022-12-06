﻿using Crimson.CSharp.Reflection;

namespace Crimson.CSharp.Statements
{
    internal class VariableAssignment: InternalStatement
    {
        public VariableAssignment()
        {
        }

        public VariableAssignment(string identifier, ResolvableValue value)
        {
            Identifier = identifier;
            Value = value;
        }

        public string Identifier { get; }
        public ResolvableValue Value { get; }
    }
}