using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Pattern
{
    class SelectAllTextCommand : Command
    {
        public override void Execute()
        {
            if (MainForm.CurrentDocument != null)
            {
                LogExecution(MainForm.CurrentDocument.Text + "select all text");
                MainForm.CurrentDocument.DocumentContent.SelectAll();
            }
        }
    }
}
