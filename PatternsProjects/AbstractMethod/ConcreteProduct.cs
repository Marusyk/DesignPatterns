using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
    class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}
