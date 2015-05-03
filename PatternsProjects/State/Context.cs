using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Context
    {
        public State State { get; set; }

        public Context(State state)
        {
            State = state;
        }

        public void Request()
        {
            State.Handle(this);
        }
    }
}
