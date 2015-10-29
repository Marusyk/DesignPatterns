using System;

namespace Builder
{
    class Program
    {
        public static void Main()
        {
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();

            Product product = builder.GetResult();
            product.Show();
        }
    }
}
