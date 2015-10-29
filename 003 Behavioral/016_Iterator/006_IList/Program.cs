using System;

namespace List
{
    class Program
    {
        static void Main()
        {
            List list = new List { 1, 2, 3, 4 };
                        
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
