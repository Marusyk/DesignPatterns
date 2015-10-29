using System;

namespace Interpreter
{
    class MainApp
    {
        static void Main()
        {
            Context context = new Context
            {
                Vocabulary = 'a',
                Source = "aaa"
            };

            var expression = new NonterminalExpression();
            expression.Interpret(context);

            Console.WriteLine(context.Result);
        }
    }
}
