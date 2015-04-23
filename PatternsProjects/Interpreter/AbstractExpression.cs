using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}
