using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Client
    {
        AbstractProductA apa;
        AbstractProductB apb;

        public Client(AbstractFactory af)
        {
            apa = af.CreateProductA();
            apb = af.CreateProductB();
        }

        public void Run()
        {
            apb.Interact(apa);
        }
    }
}
