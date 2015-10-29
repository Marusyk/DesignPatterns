using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main()
        {
            var flag = new UkraineFlag();
            flag.Draw();

            // Delay.
            Console.ReadKey();
        }
    }
}
