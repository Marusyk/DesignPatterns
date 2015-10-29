using System;
using System.Collections;

namespace Observer
{
    abstract class Subject
    {
        public ConcreteObserver aConcreteObserver {set; get;}
        public ConcreteObserver anotherConcreteObserver { set; get; }

        public abstract void SetState(string state);
        public abstract string GetState();
        
        public void Notify()
        {
            aConcreteObserver.Update();
            anotherConcreteObserver.Update();
        }
    }
}
