using System;

namespace Collection
{
    class Program
    {
        static void Main()
        {
            Collection collection = new Collection();

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 2));

            int[] array = new int[20];

            collection.CopyTo(array, 2);

            foreach (int element in array)
            {
                Console.Write(element);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
