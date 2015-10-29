using System;

namespace Visitor
{
    class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA elementA)
        {
            elementA.OperationA();
        }

        public override void VisitConcreteElementB(ConcreteElementB elementB)
        {
            elementB.OperationB();
        }
    }
}
