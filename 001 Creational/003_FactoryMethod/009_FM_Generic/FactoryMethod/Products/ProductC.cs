using System;

namespace FactoryMethod
{
    class ProductC : IProduct
    {
        public ProductC()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
