using System;

namespace Decorator
{
    class ConcreteComponentA : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponentA.Operation()");
        }
    }
}
