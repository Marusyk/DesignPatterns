using System;

namespace AbstractFactory
{
    class ConcreteFactory1 : IAbstractFactory
    {
        dynamic product;

        public dynamic Make(Product product)
        {
            // ��������� ������� ������������������ ����� �������� ��������� - 1.
            string name = this.GetType().Namespace + "." + product.ToString() + "1";

            // ������������ �������� �������� ��������� - 1. 
            this.product = Activator.CreateInstance(Type.GetType(name));

            return this.product;
        }
    }
}
