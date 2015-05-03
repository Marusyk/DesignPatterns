using State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMyExcample
{
    class Program
    {
        static void Main(string[] args)
        {
            var father = new Father();

            while (true)
            {
                Mark mark = (Mark)Enum.Parse(typeof(Mark), Console.ReadLine());

                if (mark == Mark.Two || mark == Mark.Five)
                    father.FindOut(mark);
            }

            Console.ReadKey();
        }
    }
}
