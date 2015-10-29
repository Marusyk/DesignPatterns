using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Pattern
{
    class CopyCommand : Command
    {
        public override void Execute()
        {
            if (MainForm.CurrentDocument != null)
            {
                LogExecution(MainForm.CurrentDocument.Text + "copy text: " + MainForm.CurrentDocument.DocumentContent.SelectedText);
                MainForm.CurrentDocument.Copy();
            }
        }
    }
}
