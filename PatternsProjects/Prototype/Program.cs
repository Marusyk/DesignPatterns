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


#region Prototype
            Prototype p = new ConcretePrototype();
            p.param = "param 3";
            Console.WriteLine(p.param);

            Prototype p1 = null;
            p1 = p.Clone();
            p1.param = "param 4";
            Console.WriteLine(p1.param);
#endregion

#region ProperUsingPrototype
            InterfacePrototype i = new InterfacePrototype();
            i.param = "param  5";
            Console.WriteLine(i.param);

            InterfacePrototype i1;
            i1 = i.Clone() as InterfacePrototype;
            i1.param = "param  6";
            Console.WriteLine(i.param);
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

    class InterfacePrototype : ICloneable
    {
        public string param { get; set; }
        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
