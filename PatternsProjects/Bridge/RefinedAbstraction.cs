using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor imp)
            : base(imp)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("OperationRefine");
        }
    }
}
