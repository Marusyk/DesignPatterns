using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Abstraction
    {
        protected Implementor implementor;

        public Abstraction(Implementor imp)
        {
            this.implementor = imp;
        }

        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }
}
