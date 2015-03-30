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

        internal AbstractFactory AbstractFactory
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal AbstractProductA AbstractProductA
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal AbstractProductB AbstractProductB
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Run()
        {
            apb.Interact(apa);
        }
    }
}
