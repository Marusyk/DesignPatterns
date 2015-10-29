using System;

namespace Observer
{
    // Конкретный издатель.
    class ConcreteSubject : Subject
    {
        public override string State { get; set; }

        public override void Notify()
        {
            observers.Invoke(State);
        }
    }
}
