using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ElementB : Element
    {
        public override void Accept(Visitor v)
        {
            v.VisitElementB(this);
        }

        public void OperationB()
        {
            Console.WriteLine("OperationB");
        }
    }
}
