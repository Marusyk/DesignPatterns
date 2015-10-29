using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            Creator creator = null;
            Product product = null;

            creator = new ConcreteCreator();
            product = creator.FactoryMethod();

            creator.AnOperation();
        }
    }
}
