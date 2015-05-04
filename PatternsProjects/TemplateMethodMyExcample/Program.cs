using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodMyExcample
{
    class Program
    {
        static void Main(string[] args)
        {
            var flag = new UkraineFlag();
            Console.WriteLine("Ukraine: ");
            flag.Draw();
            var flag1 = new PolandFlag();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Poland: ");
            flag1.Draw();

            Console.ReadKey();
        }
    }
}
