using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Factory1 : AbstractFactory
    {
        internal ProductA1 ProductA1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal ProductB1 ProductB1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
