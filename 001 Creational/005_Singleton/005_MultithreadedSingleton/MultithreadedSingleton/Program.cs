using System;
using System.Threading;

// Реализация паттерна Singleton с использованием подхода 
// блокировки с двойной проверкой (Double checked locking).

namespace MultithreadedSingleton
{
    class Program
    {
        static void TestMethod()
        {
            Singleton singleton = Singleton.Instance;
            Console.WriteLine(singleton.GetHashCode());
        }

        static void Main()
        {
            Thread[] threads = { 
                                   new Thread(TestMethod), 
                                   new Thread(TestMethod) 
                               };

            foreach (Thread thread in threads)
            {
                thread.Start();
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
