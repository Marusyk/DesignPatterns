using System;

// Проблемы при клонировани двухсторонней ассоциации 
// (круговых ссылок - циклических зависимостей).

namespace Features
{
    class A : ICloneable
    {
        public int a = 1;
        public B B = null;

        public A(B B)
        {
            this.B = B;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    class B : ICloneable
    {
        public int b = 2;
        public A A = null;

        public B()
        {
            this.A = new A(this);
        }

        public object Clone()
        {
            B clone = this.MemberwiseClone() as B;
            clone.A = this.A.Clone() as A;
            return clone;
        }
    }

    class Program
    {
        static void Main()
        {
            B original = new B();
            Console.WriteLine("Оригинал : " + original.b + " " + original.A.a);

            // Клонирование объекта. 
            B clone = original.Clone() as B;
            Console.WriteLine("Клон : " + clone.b + " " + clone.A.a + "\n");

            // Проверка на глубокое клонирование.
            // Попытка изменения поля b в клоне B через объект A.
            clone.A.B.b = 0;

            Console.WriteLine("Оригинал : " + original.b + " " + original.A.a);
            Console.WriteLine("Клон : " + clone.b + " " + clone.A.a + "\n");

            // Delay.
            Console.ReadKey();
        }
    }
}
