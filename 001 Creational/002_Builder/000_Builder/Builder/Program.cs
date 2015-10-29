using System;

namespace Builder
{
    class Program
    {
        public static void Main()
        {
            Builder builder = new ConcreteBuilder();
            Foreman foreman = new Foreman(builder);
            foreman.Construct();

            House house = builder.GetResult();

            // Delay.
            Console.ReadKey();
        }
    }
}
