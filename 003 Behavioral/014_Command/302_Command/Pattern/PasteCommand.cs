using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command.Pattern
{
    class PasteCommand : Command
    {

        public override void Execute()
        {

            if (MainForm.CurrentDocument != null)
            {
                LogExecution("paste text: " + Clipboard.GetText());
                MainForm.CurrentDocument.Paste();
            }
        }
    }

}
