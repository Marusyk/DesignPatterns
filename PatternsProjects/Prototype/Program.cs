using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
#region WithoutPrototype
            A a = new A();
            a.param = "param1";
            Console.WriteLine(a.param);

            A a1 = new A();
            a1.param = "param2";
            Console.WriteLine(a1.param);
            #endregion
            Prototype p = new ConcretePrototype();
            p.param = "param 3";
            Console.WriteLine(p.param);

            Prototype p1 = null;
            p1 = p.Clone();
            p1.param = "param 4";
            Console.WriteLine(p1.param);
            Console.WriteLine();

#region Prototype

#endregion
            Console.ReadKey();
        }
    }

    class A
    {
        public string param { get; set; }
    }

    abstract class Prototype
    {
        public string param { get; set; }

        public abstract Prototype Clone();
    }

    class ConcretePrototype : Prototype
    {
        public override Prototype Clone()
        {
            return new ConcretePrototype();
        }
    }
}
