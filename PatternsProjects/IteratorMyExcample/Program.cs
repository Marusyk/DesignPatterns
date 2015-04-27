using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMyExcample
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable en = new Enumerable();

            foreach (var item in en)
                Console.WriteLine(item);
        }
    }
}
