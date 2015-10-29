using System;

namespace FactoryMethod
{
    class ProductB : IProduct
    {
        public ProductB()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
