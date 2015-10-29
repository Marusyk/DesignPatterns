using System;

namespace AbstractFactory
{
    class Client
    {
        dynamic factory;
        dynamic productA;
        dynamic productB;

        public Client(Factory factory)
        {
           // ѕолучение полного квалифицированного имени фабрики в строковом представлении.
            string name = this.GetType().Namespace + "." + factory.ToString();

            // ƒинамическое создание соответствующей фабрики. 
            this.factory = Activator.CreateInstance(Type.GetType(name));

            // ѕорождение продуктов.
            this.productA = this.factory.Make(Product.ProductA);
            this.productB = this.factory.Make(Product.ProductB);
        }

        public void Run()
        {
            productB.Interact(productA);
        }
    }
}
