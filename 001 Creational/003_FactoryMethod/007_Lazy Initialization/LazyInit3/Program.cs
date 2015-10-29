using System;
using System.Threading;

namespace LazyInit
{
    public sealed class BigObject
    {
        public BigObject()
        {
            // Большая работа.
            Thread.Sleep(3000);
            Console.WriteLine("Экземпляр BigObject создан");
        }

        public void Operation()
        {
            Console.WriteLine("Operation");
        }
    }

    class Program
    {
        static void Main()
        {
            System.Lazy<BigObject> lazy = new Lazy<BigObject>();

            Console.WriteLine("Первое обращение к экземпляру BigObject...");
            // Создание объекта происходит только при этом обращении к объекту.
            lazy.Value.Operation();

            Console.WriteLine("Второе обращение к экземпляру BigObject...");
            lazy.Value.Operation();

            // Delay.
            Console.ReadKey();
        }
    }
}
