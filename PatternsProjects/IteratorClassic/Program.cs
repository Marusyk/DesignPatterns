using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorClassic
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregate a = new ConcreteAggregate();

            a[0] = "Element A";
            a[1] = "Element B";
            a[2] = "Element C";
            a[3] = "Element D";

            Iterator i = a.CreateIterator();

            for (object e = i.First(); !i.IsDone(); e = i.Next())
                Console.WriteLine(e);

            Console.ReadKey();
        }
    }
}
