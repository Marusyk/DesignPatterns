using System;

namespace AbstractFactory
{
    class ConcreteFactory1 : IAbstractFactory
    {
        dynamic product;

        public dynamic Make(Product product)
        {
            // ѕолучение полного квалифицированного имени продукта семейства - 1.
            string name = this.GetType().Namespace + "." + product.ToString() + "1";

            // ƒинамическое создание продукта семейства - 1. 
            this.product = Activator.CreateInstance(Type.GetType(name));

            return this.product;
        }
    }
}
