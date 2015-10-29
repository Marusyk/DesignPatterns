using System;

// Граф наследования клонируется глубоко.

namespace Features
{
    class A { public int a = 1; }


    class Prototype : A, ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    class Program
    {
        static void Main()
        {
            Prototype original = new Prototype();
            Console.WriteLine("Оригинал : " + original.a);

            // Клонирование объекта. 
            Prototype clone = original.Clone() as Prototype;
            Console.WriteLine("Клон : " + clone.a + "\n");

            // Проверка на глубокое клонирование.
            clone.a = 0;

            Console.WriteLine("Оригинал : " + original.a);
            Console.WriteLine("Клон : " + clone.a);

            // Delay.
            Console.ReadKey();
        }
    }
}
