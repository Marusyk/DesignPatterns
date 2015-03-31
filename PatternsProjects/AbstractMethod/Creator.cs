using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
    abstract class Creator
    {
        Product product;
        public abstract Product FactoryMethod();

        public void AnOperation()
        {
            product = FactoryMethod();
        }
    }
}
