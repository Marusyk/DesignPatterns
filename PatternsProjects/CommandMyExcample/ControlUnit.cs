using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMyExcample
{
    class ControlUnit
    {
        private List<Command> commnds = new List<Command>();
        private int current = 0;

        public void StoreCommand(Command command)
        {
            commnds.Add(command);   
        }

        public void ExecureCommand()
        {
            commnds[current].Execute();
            current++;
        }

        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
                if (current > 0)
                    commnds[--current].UnExecute();
        }

        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
                if (current < commnds.Count - 1)
                    commnds[current++].Execute();
        }
    }
}
