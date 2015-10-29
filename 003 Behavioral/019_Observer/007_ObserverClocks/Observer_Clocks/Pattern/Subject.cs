using System.Collections.Generic;

namespace Observer_Clocks
{
    abstract class Subject
    {
        protected List<Observer> observers = new List<Observer>();

        public virtual void Attach(Observer observer)
        {
            observers.Add(observer);
            observer.Update(this);
        }

        public virtual void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public virtual void Notify()
        {
            foreach (var o in observers)
                o.Update(this);
        }
    }
}
