using System;

namespace Memento
{
    class Memento : IWideInterface
    {
        public string State { get;  set; }

        public Memento(string state)
        {
            this.State = state;
        }
    }
}
