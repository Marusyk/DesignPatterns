using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMyExcample
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            int result = 0;

            // 0 + 5 = 5
            result = calculator.Add(5);
            Console.WriteLine(result);

            // 5 - 3 = 2
            result = calculator.Sub(3);
            Console.WriteLine(result);

            // undo 0 + 5 = 0
            result = calculator.Undo(2);
            Console.WriteLine(result);

            // redo 0 + 5 = 0 -> 0 + 5 = 5
           // result = calculator.Redo(1);
           // Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
