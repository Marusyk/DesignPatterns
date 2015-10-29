using System;

namespace ObserverChangeManager
{
    class Observer
    {
        public string Name { get; private set; }

        public Observer(string name)
        {
            Name = name;
        }

        public void Update(Subject subject)
        {
            Console.WriteLine("{0} -> {1}", subject.Name, this.Name);
        }
    }
}
