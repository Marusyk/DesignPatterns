using System;
using System.Threading;

namespace LazyInit
{
    public class BigObject
    {
        private static BigObject instance;

        private BigObject()
        {
            //Большая работа.
            Thread.Sleep(3000);
            Console.WriteLine("Экземпляр BigObject создан");
        }

        public override string ToString()
        {
            return "Обращение к BigObject";
        }

        // Метод возвращает экземпляр BigObject, при этом он создаёт его, если тот ещё не существует.
        public static BigObject GetInstance()
        {
            // Исключение возможности создания двух объектов в многопоточном приложении.
            if (instance == null)
            {
                lock (typeof(BigObject))
                {
                    if (instance == null)
                        instance = new BigObject();
                }
            }

            return instance;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первое обращение к экземпляру BigObject...");
            // Создание объекта происходит только при этом обращении к объекту.
            Console.WriteLine(BigObject.GetInstance());

            Console.WriteLine("Второе обращение к экземпляру BigObject...");
            Console.WriteLine(BigObject.GetInstance());

            // Delay.
            Console.ReadKey();
        }
    }
}
