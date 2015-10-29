using System;

namespace LazySingleton
{
    class Program
    {
        static void Main()
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            Console.WriteLine(singleton1.GetHashCode());
            Console.WriteLine(singleton2.GetHashCode());

            // Delay.
            Console.ReadKey();
        }
    }
}
