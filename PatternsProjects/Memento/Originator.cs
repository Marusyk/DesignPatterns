using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Originator
    {
        public string State { get; set; }

        public void SetMemento(Memento memento)
        {
            State = memento.State; 
        }

        public Memento CreateMemento()
        {
            return new Memento(State);
        }
    }
}
