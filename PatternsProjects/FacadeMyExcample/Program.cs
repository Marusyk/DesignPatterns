using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMyExcample
{
    class Program
    {
        static void Main(string[] args)
        {
            SkiResortFacade terminal = new SkiResortFacade();
            int price = terminal.HaveGoodRest(182, 75, 45, 1, 4);

            Console.WriteLine("Price: " + price);

            Console.ReadKey();
        }
    }
}
