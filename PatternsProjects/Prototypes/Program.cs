using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype = null;
            Prototype clone = null;

            prototype = new ConcretePrototype1(1);
            clone = prototype.Clone();

            prototype = new ConcretePrototype2(2);
            clone = prototype.Clone();
        }
    }

    abstract class Prototype
    {
        public int Id { get; set; }

        public Prototype(int id)
        {
            this.Id = id;
        }

        public abstract Prototype Clone();
    }

    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            return new ConcretePrototype1(Id);
        }
    }

    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            return new ConcretePrototype2(Id);
        }
    }
}
