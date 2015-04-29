using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoMyExcample
{
    class Program
    {
        static void Main(string[] args)
        {
            Man David = new Man();
            Robot ASIMO = new Robot();

            David.Clothes = "Футболка, Джинси, Кеди";
            Console.WriteLine("David: " + David.Clothes);

            ASIMO.Backpack = David.Undress();

            David.Clothes = "Шорти";
            Console.WriteLine("David: " + David.Clothes);

            David.Dress(ASIMO.Backpack as Backpack);
            Console.WriteLine("David: " + David.Clothes);

            Console.ReadKey();
        }
    }
}
