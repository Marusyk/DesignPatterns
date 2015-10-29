using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Pattern
{
    class CutCommand : Command
    {
        public override void Execute()
        {
            if (MainForm.CurrentDocument != null)
            {
                LogExecution("cut text: " + MainForm.CurrentDocument.DocumentContent.SelectedText);
                MainForm.CurrentDocument.Cut();
            }
        }
    }
}
