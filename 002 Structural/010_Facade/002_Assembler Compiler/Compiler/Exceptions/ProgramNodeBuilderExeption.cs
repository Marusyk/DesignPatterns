using System;

namespace CompilationSystem
{
    class ProgramNodeBuilderExeption : Exception
    {
        public ProgramNodeBuilderExeption(string message)
            : base(message)
        {
        }
    }
}
