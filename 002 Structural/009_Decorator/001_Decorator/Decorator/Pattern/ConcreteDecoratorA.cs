using System;

namespace Decorator
{
    class ConcreteDecoratorA : Decorator
    {
        string addedState = "Some State";

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine(addedState);
        }
    }
}
