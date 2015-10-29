using System;
using System.Diagnostics;
using System.Threading;

// Клонирование с использованием MemberwiseClone().

// Преимущество клонирования с использованием MemberwiseClone() в том, что
// при клонировании не вызывается конструктор, а клонирование происходит через
// копирование дампа памяти - тела оригинала.

namespace Cloning
{
    class MyClass : ICloneable
    {
        int a, b;

        public MyClass()
        {
            Thread.Sleep(1000);
            a = new Random().Next(1, 100);
            Thread.Sleep(1000);
            b = new Random().Next(1, 100);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    class Program
    {
        static void Main()
        {
            Stopwatch timer = new Stopwatch();

            // Замер времени построения оригинала.

            timer.Start();
            MyClass original = new MyClass();
            timer.Stop();
            Console.WriteLine("original построен за {0}", timer.Elapsed.Ticks);

            timer.Reset();

            // Замер времени построения клона.

            timer.Start();
            MyClass clone = original.Clone() as MyClass;
            timer.Stop();
            Console.WriteLine("clone    построен за {0}", timer.Elapsed.Ticks);

            // Delay.
            Console.ReadKey();
        }
    }
}
