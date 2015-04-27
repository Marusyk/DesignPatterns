using System;

namespace IteratorMicrosoft
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable a = new Enumerable();

            a[0] = "Element A";
            a[1] = "Element B";
            a[2] = "Element C";
            a[3] = "Element D";

            foreach(var item in a)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
