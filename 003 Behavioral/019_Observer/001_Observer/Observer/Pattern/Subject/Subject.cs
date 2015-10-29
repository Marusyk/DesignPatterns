using System;
using System.Collections;

namespace Observer
{
    abstract class Subject
    {
        ArrayList observers = new ArrayList();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer observer in observers)
                observer.Update();
        }
    }
}
