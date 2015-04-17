using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();

            h1.Successor = h2;
            h1.HandleRequest(1);
            h1.HandleRequest(2);
            h1.HandleRequest(3);

            Console.ReadKey();   
        }
    }
}
