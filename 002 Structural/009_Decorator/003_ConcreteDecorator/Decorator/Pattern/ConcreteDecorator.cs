using System;

namespace Decorator
{
    class ConcreteDecorator : Component
    {
        public Component Component { protected get; set; }

        void AddedBehavior()
        {
            Console.WriteLine("AddedBehavior");
        }

        public override void Operation()
        {
            if (Component != null)
                Component.Operation();

            AddedBehavior();
        }
    }
}
