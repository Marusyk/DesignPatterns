using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Factory2 : AbstractFactory
    {
        internal ProductA2 ProductA2
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal ProductB2 ProductB2
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
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
