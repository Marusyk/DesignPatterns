using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
    class ConcreteCreator : Creator
    {
        internal ConcreteProduct ConcreteProduct
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public override Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
