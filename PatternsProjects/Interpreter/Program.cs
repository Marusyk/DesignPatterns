using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context
            {
                Vocabulary = 'a',
                Source = "aaa"
            };

            var expression = new NoterminalExpression();
            expression.Interpret(context);

            Console.WriteLine(context.Result);

            Console.ReadKey();
        }
    }
}
