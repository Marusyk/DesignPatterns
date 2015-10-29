using System;
using System.Collections.Generic;

namespace Composite
{
    class Composite : Component
    {
        Dictionary<int, Component> nodes = new Dictionary<int, Component>();

        public Composite(string name)
            : base(name)
        {
        }

        int position = -1;
        
        // Метод использующий технику рекурсивной композиции для построения дерева.
        public override void Build(int[] rules)
        {
            if (position < rules.Length - 1)
            {
                int result = rules[++position] % 2;

                if (!nodes.ContainsKey(result))
                    nodes.Add(result, new Composite("branch " + result.ToString()));

                nodes[result].Add(position, new Leaf(rules[position].ToString()));
                
                Build(rules);
            }            
        }

        // Метод использующий технику рекурсивного обхода дерева.
        public override void Operation()
        {
            Console.WriteLine(name);

            foreach (var component in nodes)
                component.Value.Operation();
        }

        public override void Add(int key, Component component)
        {
            nodes.Add(key, component);
        }        
    }
}
