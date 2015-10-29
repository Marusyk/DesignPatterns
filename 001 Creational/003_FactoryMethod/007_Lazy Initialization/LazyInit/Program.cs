using System;
using System.Threading;

/*
    Отложенная (ленивая) инициализация (англ. Lazy initialization). 
    Приём в программировании, когда некоторая ресурсоёмкая операция (создание объекта, вычисление значения) 
    выполняется непосредственно перед тем, как будет использован её результат. 
    Таким образом, инициализация выполняется «по требованию», а не заблаговременно. 
    Аналогичная идея находит применение в самых разных областях: 
    например, компиляция «на лету» и логистическая концепция «Точно в срок». 
    
    Частный случай ленивой инициализации — создание объекта в момент обращения к нему — 
    является одним из порождающих шаблонов проектирования. 
    Как правило, он используется в сочетании с такими шаблонами как Фабричный метод, Одиночка и Заместитель.
*/

namespace LazyInit
{
    public class LazyInitialization<T> where T : new()
    {
        protected LazyInitialization() { }

        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (typeof(T))
                    {
                        if (instance == null)
                        {
                            instance = new T();
                        }
                    }
                }
                return instance;
            }
        }
    }

    public sealed class BigObject : LazyInitialization<BigObject>
    {
        public BigObject()
        {
            // Большая работа.
            Thread.Sleep(3000);
            Console.WriteLine("Экземпляр BigObject создан");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первое обращение к экземпляру BigObject...");
            // Создание объекта происходит только при этом обращении к объекту.
            Console.WriteLine(BigObject.Instance);

            Console.WriteLine("Второе обращение к экземпляру BigObject...");
            Console.WriteLine(BigObject.Instance);

            // Delay.
            Console.ReadKey();
        }
    }
}
