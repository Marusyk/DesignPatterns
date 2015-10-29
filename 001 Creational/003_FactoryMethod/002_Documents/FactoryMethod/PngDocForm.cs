using FactoryMethod.Pattern;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FactoryMethod
{
    public partial class PngDocForm : Form
    {
        private readonly PngDocument png;

        public PictureBox PictureBox1
        {
            get { return pictureBox1; }
            set { pictureBox1 = value; }
        }

        public Label LabelColor
        {
            get { return lblColor; }
            set { lblColor = value; }
        }

        public PngDocForm(Form parent, PngDocument png)
        {
            InitializeComponent();
            this.png = png;
            MdiParent = parent;
            panel1.Left = 65;
            InitializePictureBox();
        }

        private void InitializePictureBox()
        {
            pictureBox1.Height = panel1.Height = PngDocForm.ActiveForm.Height - 100;
            pictureBox1.Width = panel1.Width = PngDocForm.ActiveForm.Width - 90;

            Image im = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(im);
            g.Clear(Color.White);
            g.Dispose();

            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();

            pictureBox1.Image = im;
        }

        private void openToolStripButton1_Click(object sender, EventArgs e)
        {
            png.Open();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            png.SaveAs();
        }

        private void clearToolStripButton_Click(object sender, EventArgs e)
        {
            png.Clear();
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            png.ChooseColor();
        }

        private void closeToolStripButton_Click(object sender, EventArgs e)
        {
            png.Close();
        }
    }
}
