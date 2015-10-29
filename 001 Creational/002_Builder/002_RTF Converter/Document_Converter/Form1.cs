using System;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace Document_Converter
{
    public partial class Form1 : Form
    {
        static public string FileLocation { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileLocation = openFileDialog1.FileName;

            if (FileLocation != null)
            {
                lblSelectedFile.Text = Path.GetFileName(FileLocation);
                btnGetASCII.Enabled = true;
                btnGetPDF.Enabled = true;
                btnGetWidget.Enabled = true;
            }
        }

        private void btnGetASCII_Click(object sender, EventArgs e)
        {
            // ConcreteBuilder
            ASCIIConverter converter = new ASCIIConverter();

            // Director
            RTFReader reader = new RTFReader(converter);

            reader.ParserRTF(File.ReadAllText(FileLocation));
            ASCIIText text = converter.GetASCIIText();

            text.WriteToFile("ASCIItest.txt");

            MessageBox.Show("File has been saved as ASCIItest.txt");
        }

        private void btnGetWidget_Click(object sender, EventArgs e)
        {
            // ConcreteBuilder
            TextWidgetConverter converter = new TextWidgetConverter();

            // Director
            RTFReader reader = new RTFReader(converter);

            reader.ParserRTF(File.ReadAllText(FileLocation));
            TextWidget textWidget = converter.GetTextWidget();

            textWidget.Dock = DockStyle.Fill;
            Form frm = new Form();
            frm.Controls.Add(textWidget);
            frm.WindowState = FormWindowState.Normal;
            frm.ShowDialog();
        }

        private void btnGetPDF_Click(object sender, EventArgs e)
        {
            // ConcreteBuilder
            PDFConverter converter = new PDFConverter();

            // Director
            RTFReader reader = new RTFReader(converter);

            reader.ParserRTF(File.ReadAllText(FileLocation));
            PDFText text = converter.GetPDFText();

            text.WriteToFile("PDFtest.pdf");
            MessageBox.Show("File has been saved as PDFtest.pdf");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
