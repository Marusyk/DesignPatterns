using System;

namespace Yield
{
    class Program
    {
        static void Main()
        {
            Enumerable enumerable = new Enumerable();

            foreach (var item in enumerable)
            {
                Console.WriteLine(item);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
