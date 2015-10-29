using System;
using CompilationSystem;

namespace Facade
{
    class Program
    {
        public static void Main()
        {
            string sourceCode = "var1 dd 5;" +
                                "var2 dd 2;" +
                                "xor eax, eax;" +
                                "mov eax, var1;" +
                                "add eax, var2;" +
                                //"sub eax, var1;" +
                                //"mov eax, 1;" +
                                //"nop;" +

                                "call HexMessage;" +
                                "call ExitProcess;";

            Action<string> message = msg => Console.WriteLine(msg);

            Compiler compiler = new Compiler();
            compiler.Compile(sourceCode, "result.exe", message);

            // Delay.
            Console.ReadKey();
        }
    }
}
