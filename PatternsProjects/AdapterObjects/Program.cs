using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();

            Console.ReadKey(); 
        }
    }
}
