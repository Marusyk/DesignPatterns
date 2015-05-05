using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ElementA : Element
    {
        public override void Accept(Visitor v)
        {
            v.VisitElementA(this);
        }

        public void OperationA()
        {
            Console.WriteLine("OperationA");
        }
    }
}
