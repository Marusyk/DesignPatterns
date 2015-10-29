using System;

namespace Visitor
{
    class Program
    {
        static void Main()
        {
            ObjectStructure structure = new ObjectStructure();

            structure.Add(new ConcreteElementA());
            structure.Add(new ConcreteElementB());

            structure.Accept(new ConcreteVisitor1());
            structure.Accept(new ConcreteVisitor2());
        }
    }
}
