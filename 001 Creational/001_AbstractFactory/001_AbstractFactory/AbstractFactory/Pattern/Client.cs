using System;

namespace AbstractFactory
{
    class Client
    {
        private AbstractProductA abstractProductA = null;
        private AbstractProductB abstractProductB = null;

        public Client(AbstractFactory factory)
        {
            this.abstractProductA = factory.CreateProductA();
            this.abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            this.abstractProductB.Interact(this.abstractProductA);
        }
    }
}
