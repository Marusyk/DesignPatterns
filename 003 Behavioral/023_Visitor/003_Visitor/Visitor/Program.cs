using System;

namespace Visitor
{
    class Program
    {
        static void Main()
        {
            ObjectStructure structure = new ObjectStructure();

            structure.Add(new ElementA());
            structure.Add(new ElementB());

            structure.Accept(new ConcreteVisitor());

        }
    }
}
