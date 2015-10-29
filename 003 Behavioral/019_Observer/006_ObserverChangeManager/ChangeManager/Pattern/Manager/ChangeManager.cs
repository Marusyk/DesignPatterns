using System.Collections.Generic;

namespace ObserverChangeManager
{
    abstract class ChangeManager
    {
        protected Dictionary<Subject, List<Observer>> mapping = null;

        public ChangeManager()
        {
            mapping = new Dictionary<Subject, List<Observer>>();
        }

        public abstract void Register(Subject subject, Observer observer);
        public abstract void Unregister(Subject subject, Observer observer);
        public abstract void Notify();
    }
}
