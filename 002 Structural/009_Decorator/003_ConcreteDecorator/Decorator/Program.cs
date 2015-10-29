using System;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            ConcreteDecorator decorator = new ConcreteDecorator();

            Component component = new ConcreteComponentA();
            decorator.Component = component;
            decorator.Operation();

            Console.WriteLine(new string('-', 30));

            component = new ConcreteComponentB();
            decorator.Component = component;
            decorator.Operation();

            // Delay.
            Console.ReadKey();
        }
    }
}
