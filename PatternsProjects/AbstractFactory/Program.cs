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
            Console.WriteLine("***** Firebird *****");
            Client provider = new Client(new FireBirdProvider());
            provider.Run();

            Console.WriteLine();
            Console.WriteLine("***** Oracle *****");

            provider = new Client(new OracleProvider());
            provider.Run();

            Console.ReadKey();
        }
    }
}
