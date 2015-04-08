using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMyExcample
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Triangle();
            shape.implementor = new LineType1();
            shape.Draw("red");

            shape.implementor = new LineType2();
            shape.Draw("black");

            Console.ReadKey();
        }
    }
}
