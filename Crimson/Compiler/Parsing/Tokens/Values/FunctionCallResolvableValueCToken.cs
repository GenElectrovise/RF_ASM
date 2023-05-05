﻿using CrimsonCore.Exceptions;
using CrimsonCore.Generalising.Structures;
using CrimsonCore.Specialising;
using CrimsonCore.Linking;
using CrimsonCore.Parsing.Statements;

namespace CrimsonCore.Parsing.Tokens.Values
{
    public class FunctionCallResolvableValueCToken : ComplexValueCToken
    {
        public FunctionCallCStatement FunctionCall { get; }

        public FunctionCallResolvableValueCToken (FunctionCallCStatement functionCall)
        {
            FunctionCall = functionCall;
        }

        public override void Link (LinkingContext ctx)
        {
            FunctionCall.Link(ctx);
        }

        public override string ToString ()
        {
            return "Call: " + FunctionCall.Identifier.ToString() + "()";
        }
    }
}