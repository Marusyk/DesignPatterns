using System;

namespace Flyweight
{
    class ConcreteFlyweight : Flyweight
    {
        string intrinsicState = "ConcreteFlyweight ";
        ConsoleColor extrinsicState;

        public override void Operation(ConsoleColor extrinsicState)
        {
            this.extrinsicState = extrinsicState;
            Console.ForegroundColor = this.extrinsicState;
            Console.WriteLine(intrinsicState + GetHashCode());
        }
    }
}
