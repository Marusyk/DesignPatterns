using System;

namespace CompilationSystem
{
    class ParserException : Exception
    {
        public ParserException(string message)
            : base(message)
        {
        }
    }
}
