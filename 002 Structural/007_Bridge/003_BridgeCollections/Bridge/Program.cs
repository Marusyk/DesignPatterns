using System;

namespace Bridge
{
    class Program
    {
        static void Main()
        {
            Abstraction abstraction;

            abstraction = new RefinedAbstraction(3);
            Console.WriteLine(abstraction.Implementor.GetType());

            abstraction = new RefinedAbstraction(30);
            Console.WriteLine(abstraction.Implementor.GetType());

            // Delay.
            Console.ReadKey();
        }
    }
}
