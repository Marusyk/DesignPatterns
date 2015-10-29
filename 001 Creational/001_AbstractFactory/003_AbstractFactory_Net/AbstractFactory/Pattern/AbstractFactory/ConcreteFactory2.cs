using System;

namespace AbstractFactory
{
    class ConcreteFactory2 : IAbstractFactory
    {
        dynamic product;

        public dynamic Make(Product product)
        {
            // ѕолучение полного квалифицированного имени продукта семейства - 2.
            string name = this.GetType().Namespace + "." + product.ToString() + "2";

            // ƒинамическое создание продукта семейства - 2. 
            this.product = Activator.CreateInstance(Type.GetType(name));

            return this.product;
        }
    }
}
