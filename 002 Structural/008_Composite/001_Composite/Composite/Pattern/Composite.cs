using System;
using System.Collections;

namespace Composite
{
    class Composite : Component
    {
        ArrayList nodes = new ArrayList();

        public Composite(string name)
            : base(name)
        {
        }

        public override void Operation()
        {
            Console.WriteLine(name);

            foreach (Component component in nodes)
                component.Operation();
        }

        public override void Add(Component component)
        {
            nodes.Add(component);
        }

        public override void Remove(Component component)
        {
            nodes.Remove(component);
        }

        public override Component GetChild(int index)
        {
            return nodes[index] as Component;
        }
    }
}
