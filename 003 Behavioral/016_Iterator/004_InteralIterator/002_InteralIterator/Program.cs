using System;
using System.Collections;

namespace InternalIterator
{
    delegate double Function(double arg);

    class Program
    {
        static double Power2(double n)
        {
            return Math.Pow(n, 2);
        }

        static void Main()
        {
            Enumerable enumerable = new Enumerable();

            IEnumerable power2List = enumerable.Transform(new Function(Power2));

            foreach (var item in power2List)
                Console.WriteLine(item);

            IEnumerable power3List = enumerable.Transform(n => Math.Pow(n, 3));

            foreach (var item in power3List)
                Console.WriteLine(item);

            // Задержка.
            Console.ReadKey();
        }
    }
}
