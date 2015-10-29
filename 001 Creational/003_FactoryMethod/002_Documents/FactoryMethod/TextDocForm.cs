using System;
using System.Windows.Forms;
using FactoryMethod.Pattern;

namespace FactoryMethod
{
    public partial class TextDocForm : Form
    {
        private readonly TextDocument myDoc;

        public TextDocForm(Form parent, TextDocument myDoc)
        {
            InitializeComponent();
            this.myDoc = myDoc;
            MdiParent = parent;
        }

        public void ShowText(RichTextBox inputText)
        {
            richTextBox1.Text = inputText.Text;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            myDoc.Open();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            myDoc.SaveAs();
        }

        private void saveAsToolStripButton_Click(object sender, EventArgs e)
        {
            myDoc.SaveAs();
        }

        private void revertToolStripButton_Click(object sender, EventArgs e)
        {
            myDoc.Clear();
        }

        private void closeToolStripButton_Click(object sender, EventArgs e)
        {
            myDoc.Close();
        }
    }
}
