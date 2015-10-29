using System;

namespace Command
{
    // "Command"
    abstract class Command
    {
        protected ArithmeticUnit unit;
        protected int operand;

        public abstract void Execute();
        public abstract void UnExecute();
    }
}
