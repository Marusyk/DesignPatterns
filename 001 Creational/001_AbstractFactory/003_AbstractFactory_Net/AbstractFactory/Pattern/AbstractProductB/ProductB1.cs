using System;

namespace AbstractFactory
{
    class ProductB1 : IAbstractProductB
    {
        public void Interact(IAbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " ��������������� � " + a.GetType().Name);
        }
    }
}
