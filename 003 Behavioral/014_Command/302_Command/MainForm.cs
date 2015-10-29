using Command.Pattern;
using System;
using System.Windows.Forms;

namespace Command
{
    public partial class MainForm : Form
    {
        internal static Document CurrentDocument { get; set; }
        internal static MainForm MainFormInstance { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { 
                new MyMenuItem("Open",new OpenCommand()),
                new MyMenuItem("Close",new CloseCommand()),
                new ToolStripSeparator(),
                new MyMenuItem("Cut",new CutCommand()),
                new MyMenuItem("Copy",new CopyCommand()),
                new MyMenuItem("Paste",new PasteCommand()),
                new ToolStripSeparator(),
                new MyMenuItem("MacroCopy",new MacroCommand(new OpenCommand(),
                                                            new SelectAllTextCommand(),
                                                            new CopyCommand(),
                                                            new CloseCommand()))
        });
            MainFormInstance = this;
        }
        public void AddDocument(Document document)
        {
            document.MdiParent = this;
            document.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        public void Log(string logString)
        {
            logLabel.Text += Environment.NewLine + logString;
        }
    }

}
