using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class NoterminalExpression : AbstractExpression
    {
        AbstractExpression noterminalExpression;
        AbstractExpression terminalExpression;

        public override void Interpret(Context context)
        {
            if (context.Position < context.Source.Length)
            {
                terminalExpression = new TerminalExpression();
                terminalExpression.Interpret(context);
                context.Position++;

                if (context.Result)
                {
                    noterminalExpression = new NoterminalExpression();
                    noterminalExpression.Interpret(context);
                }
            }
        }
    }
}
