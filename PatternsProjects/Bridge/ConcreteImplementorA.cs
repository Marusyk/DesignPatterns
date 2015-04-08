using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class ConcreteImplementorA : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ImplementorA");
        }
    }
}
