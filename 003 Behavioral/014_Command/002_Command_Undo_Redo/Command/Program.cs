using System;

namespace Command
{
    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            int result = 0;

            result = calculator.Add(5);
            Console.WriteLine(result);

            result = calculator.Sub(3);
            Console.WriteLine(result);

            Console.WriteLine(new string('-', 3));

            result = calculator.Undo(2);
            Console.WriteLine(result);

            result = calculator.Redo(1);
            Console.WriteLine(result);

            // Delay.
            Console.ReadKey();
        }
    }
}
