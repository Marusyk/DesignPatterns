using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Proxy();
            subject.Request();

            Console.ReadKey();
        }
    }
}
