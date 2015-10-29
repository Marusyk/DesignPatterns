using System;

namespace Visitor
{
    public static class Visitors
    {     
        public static void VisitConcreteElementA(this ElementA element)
        {
            element.OperationA();
        }

        public static void VisitConcreteElementB(this ElementB element)
        {
            element.OperationB();
        }
    }

    public class ElementA
    {
        public void OperationA()
        {
            Console.WriteLine("OperationA");
        }
    }

    public class ElementB
    {
        public void OperationB()
        {
            Console.WriteLine("OperationB");
        }
    }

    class Program
    {
        static void Main()
        {
            ElementA elementA = new ElementA();
            ElementB elementB = new ElementB();

            elementA.VisitConcreteElementA();
            elementB.VisitConcreteElementB();

            // Задержка. 
            Console.ReadKey();
        }
    }
}
