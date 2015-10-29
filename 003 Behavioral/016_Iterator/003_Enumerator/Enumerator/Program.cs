using System;

namespace Enumerator
{
    class Program
    {
        static void Main()
        {
            Enumerable enumerable = new Enumerable();

            enumerable[0] = "Element A";
            enumerable[1] = "Element B";
            enumerable[2] = "Element C";
            enumerable[3] = "Element D";
                        
            foreach (var item in enumerable)
            {
                Console.WriteLine(item);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}