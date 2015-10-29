using System;

namespace Composite
{
    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Operation();
        public abstract void Build(int[] rules);
        public abstract void Add(int key, Component component);
    }
}
