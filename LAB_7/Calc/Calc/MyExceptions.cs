using System;
using System.Runtime.InteropServices;

namespace Calc
{
    public class ParseExceptions : Exception
    {
        public ParseExceptions(string message) : base(message)
        {
        }
    }

    public class EnteringExceptions : Exception
    {
        public EnteringExceptions(string message) : base(message)
        {
        }
    }
}