using System;

namespace ObserverChangeManager
{
    class Subject
    {
        ChangeManager manager;
        public string Name { get; private set; }

        public Subject(string name, ChangeManager manager)
        {
            Name = name;
            this.manager = manager;
        }

        public void Attach(Observer observer)
        {
            manager.Register(this, observer);
        }

        public void Detach(Observer observer)
        {
            manager.Unregister(this, observer);
        }

        public void Notify()
        {
            manager.Notify();
        }
    }
}
