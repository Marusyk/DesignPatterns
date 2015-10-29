using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command.Pattern
{
    class OpenCommand : Command
    {
        public override void Execute()
        {
            var filename = AskUser();
            if (!string.IsNullOrEmpty(filename))
            {
                var doc = new Document();
                doc.Open(filename);
                LogExecution(" opened");
                MainForm.MainFormInstance.AddDocument(doc);
            }
            else
            { LogExecution(" opening cancelled"); }
        }
        string AskUser()
        {
            LogExecution("Asking user.");
            var dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return dlg.FileName;
            }
            else
                return string.Empty;
        }
    }
}
