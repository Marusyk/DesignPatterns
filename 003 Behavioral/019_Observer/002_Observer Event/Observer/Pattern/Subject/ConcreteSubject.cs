using System;

namespace Observer
{
    // ���������� ��������.
    class ConcreteSubject : Subject
    {
        public override string State { get; set; }

        public override void Notify()
        {
            observers.Invoke(State);
        }
    }
}
