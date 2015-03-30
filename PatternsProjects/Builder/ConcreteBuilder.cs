using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class ConcreteBuilder : Builder
    {
        Product product = new Product();

        internal Product Product
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public override void BuildPartA()
        {
            product.Add("Part A");
        }

        public override void BuildPartB()
        {
            product.Add("Part B");
        }

        public override void BuildPartC()
        {
            product.Add("Part C");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
