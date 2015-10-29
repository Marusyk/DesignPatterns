using System;

// Клонирование ассоциации происходит поверхностно.

namespace Features
{
    class A { public int a = 1; }

    class Prototype : ICloneable
    {
        public A A = new A();

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
            Console.WriteLine("Оригинал : " + original.A.a);

            // Клонирование объекта. 
            Prototype clone = original.Clone() as Prototype;
            Console.WriteLine("Клон : " + clone.A.a + "\n");

            // Проверка на глубокое клонирование.
            clone.A.a = 0;

            Console.WriteLine("Оригинал : " + original.A.a);
            Console.WriteLine("Клон : " + clone.A.a);

            // Delay.
            Console.ReadKey();
        }
    }
}
