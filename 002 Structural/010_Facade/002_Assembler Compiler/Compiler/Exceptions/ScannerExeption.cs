using System;

namespace CompilationSystem
{
    class ScannerExeption : Exception
    {
        public ScannerExeption(string message)
            : base(message)
        {
        }
    }
}
