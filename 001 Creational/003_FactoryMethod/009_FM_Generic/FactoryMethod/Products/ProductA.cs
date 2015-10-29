using System;

namespace FactoryMethod
{
    class ProductA : IProduct
    {
        public ProductA()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
