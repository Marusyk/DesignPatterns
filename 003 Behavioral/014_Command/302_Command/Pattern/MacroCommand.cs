using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Pattern
{
    class MacroCommand : Command
    {
          public readonly List<Command> Commands = new List<Command>();

        public MacroCommand()
        { }
        public MacroCommand(params Command[] commands)
        {
            Commands.AddRange(commands);
        }
      
        public override void Execute()
        {
            foreach (var c in Commands)
                c.Execute();
        }
    }
}
