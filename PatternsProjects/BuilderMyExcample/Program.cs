using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMyExcample
{
    class Program
    {
        static void Main(string[] args)
        {
            // create cola
            CocaColaWater cola = new CocaColaWater();
            Director director = new Director(cola);
            director.Create();

            Soda soda = cola.GetSoda();
            Console.WriteLine("Result: {0}", soda.SodaProduct());

            Console.WriteLine();

            // create pepsi
            PepsiWater pepsi = new PepsiWater();
            director = new Director(pepsi);
            director.Create();
            soda = pepsi.GetSoda();
            Console.WriteLine("Result: {0}", soda.SodaProduct());

            Console.ReadKey();
        }
    }
}
