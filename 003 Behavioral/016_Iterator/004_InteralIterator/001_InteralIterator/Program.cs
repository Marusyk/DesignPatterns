using System;
using System.Collections;
using System.Collections.Generic;

namespace InternalIterator
{
    delegate double Function(double arg);

    class Enumerable
    {
        List<double> list = new List<double> { 1, 2, 3, 4 };

        public IEnumerable Transform(Function function)
        {
            foreach (double item in list)
                yield return function(item);
        }
    }

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
