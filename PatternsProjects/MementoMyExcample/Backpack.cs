using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoMyExcample
{
    class Backpack : IWideInterface
    {
        private string state;

        public string GetState()
        {
            return state;
        }

        public void SetState(string s)
        {
            state = s;
        }

        public Backpack(string state)
        {
            this.state = state;
        }
    }
}
