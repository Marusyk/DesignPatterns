using System;

// Клонирование ассоциации.

namespace Features
{
    class A : ICloneable
    {
        public int a = 1;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    class Prototype : ICloneable
    {
        public A A = new A();

        public object Clone()
        {
            Prototype clone = this.MemberwiseClone() as Prototype;
            clone.A = this.A.Clone() as A;
            return clone;
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
