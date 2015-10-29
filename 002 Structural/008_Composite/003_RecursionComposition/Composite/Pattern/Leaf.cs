using System;

namespace Composite
{
    class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        {
        }

        public override void Operation()
        {
            Console.WriteLine(name);
        }

        public override void Build(int[] rules)
        {
            throw new InvalidOperationException();
        }

        public override void Add(int key, Component component)
        {
            throw new InvalidOperationException();
        }
    }
}
