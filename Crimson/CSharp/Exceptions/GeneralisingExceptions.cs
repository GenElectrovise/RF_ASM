﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crimson.CSharp.Exceptions
{
    internal class GeneralisingException : ArgumentException
    {
        public GeneralisingException (string message) : base(message)
        {

        }

        public GeneralisingException (string message, Exception cause) : base(message, cause)
        {

        }
    }
}
