using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMyExcample
{
    class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;

        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }

        public int Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecureCommand();
            return arithmeticUnit.Register;
        }

        public int Add(int operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }

        public int Sub(int operand)
        {
            return Run(new Sub(arithmeticUnit, operand));
        }

        public int Mul(int operand)
        {
            return Run(new Mul(arithmeticUnit, operand));
        }

        public int Div(int operand)
        {
            return Run(new Div(arithmeticUnit, operand));
        }

        public int Undo(int levels)
        {
            controlUnit.Undo(levels);
            return arithmeticUnit.Register;
        }

        public int Redo(int levels)
        {
            controlUnit.Redo(levels);
            return arithmeticUnit.Register;
        }
    }
}
