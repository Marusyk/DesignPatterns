using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ConcreteDecoratorB : Decorator
    {
        void AddedBehavior()
        {
            Console.WriteLine("Behavior");
        }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }
    }
}
