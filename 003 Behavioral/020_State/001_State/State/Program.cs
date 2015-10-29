using System;

namespace State
{
    class Program
    {
        static void Main()
        {
            Context context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
        }
    }
}
