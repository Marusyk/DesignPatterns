using System;

namespace AbstractFactory
{
    class ProductB2 : IAbstractProductB
    {
        public void Interact(IAbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " ��������������� � " + a.GetType().Name);
        }
    }
}
