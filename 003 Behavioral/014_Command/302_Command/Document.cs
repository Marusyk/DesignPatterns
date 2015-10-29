using System;
using System.IO;
using System.Windows.Forms;

namespace Command
{
    public class Document : Form
    {
        static int docsCount;
        public RichTextBox DocumentContent { get; private set; }
        public Document()
            : base()
        {
            DocumentContent = new RichTextBox();
            DocumentContent.ShortcutsEnabled = false;
            DocumentContent.Parent = this;
            DocumentContent.Dock = DockStyle.Fill;
            this.Text = "Новый документ № " + docsCount++;
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            MainForm.CurrentDocument = this;
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            MainForm.CurrentDocument = null;
            base.OnClosing(e);

        }

        public void Open(string filename)
        {
            if (File.Exists(filename))
            {
                this.Text = filename;
                DocumentContent.Text = File.ReadAllText(filename);
            }
        }
        public new void Close()
        {
            base.Close();
        }

        public void Cut()
        {
            DocumentContent.Cut();
        }
        public void Copy()
        {
            DocumentContent.Copy();
        }
        public void Paste()
        {
            DocumentContent.Paste();
        }
    }
}
