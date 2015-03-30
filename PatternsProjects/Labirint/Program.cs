using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;

            client = new Client(new Factory1());
            client.Run();

            client = new Client(new Factory2());
            client.Run();

            Console.ReadKey();
        }
    }
}
