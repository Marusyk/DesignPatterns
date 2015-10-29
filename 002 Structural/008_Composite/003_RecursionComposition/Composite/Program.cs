using System;

namespace Composite
{
    class Program
    {
        static void Main()
        {
            int[] array = null;

            array = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Component tree = new Composite("root");

            tree.Build(array);

            tree.Operation();

            // Delay.
            Console.ReadKey();
        }
    }
}
