using System;

namespace Observer
{
    class ConcreteObserver : Observer
    {
        string state;
        ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update()
        {
            state = subject.GetState();
            Console.WriteLine("Observer {0} has state - {1}", 
                GetHashCode(), state);
        }

        public void ChangeState(string state)
        {
            this.state = state;
            this.subject.SetState(state);
        }
    }
}
