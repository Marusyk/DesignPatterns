using System;

namespace Decorator
{
    class ConcreteComponentB : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponentB.Operation()");
        }
    }
}
