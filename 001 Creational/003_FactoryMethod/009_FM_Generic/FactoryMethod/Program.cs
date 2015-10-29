using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            ICreator creator = new StandardCreator();

            IProduct productA = creator.CreateProduct<ProductA>();
            IProduct productB = creator.CreateProduct<ProductB>();
            IProduct productC = creator.CreateProduct<ProductC>();

            // Задержка.
            Console.ReadKey();
        }
    }
}
