using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod.Pattern
{
    // ConcreteProductB
    public class PngDocument : Document
    {
        private Pen pen = new Pen(Color.Black);
        private Point startPt;
        private Point movePt;
        private Point nullPt = new Point(int.MaxValue, 0);
        private SolidBrush brush = new SolidBrush(Color.White);
        private Bitmap oldImage;
        private OpenFileDialog openFile;
        private SaveFileDialog saveFile;
        private PngDocForm paintingForm;
        private ColorDialog colorDialog;

        public PngDocument(Form baseForm, int counter, Action action)
        {
            openFile = new OpenFileDialog();
            saveFile = new SaveFileDialog();
            colorDialog = new ColorDialog();
            openFile.Filter = saveFile.Filter = @"Image files (*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";
            openFile.FileName = saveFile.FileName = @"Image";

            paintingForm = new PngDocForm(baseForm, this);
            paintingForm.WindowState = FormWindowState.Maximized;
            paintingForm.Text = string.Format(@"Document{0}", counter);

            oldImage = new Bitmap(paintingForm.PictureBox1.Image);

            if (action == Action.NewDoc)
                paintingForm.Show();

            paintingForm.PictureBox1.MouseDown += PictureBox1_MouseDown;
            paintingForm.PictureBox1.MouseMove += PictureBox1_MouseMove;
        }

        public override void Open()
        {
            startPt = nullPt;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string s = openFile.FileName;

                try
                {
                    Image im = new Bitmap(s);
                    Graphics g = Graphics.FromImage(im);
                    g.Dispose();
                    if (paintingForm.PictureBox1.Image != null)
                        paintingForm.PictureBox1.Image.Dispose();

                    paintingForm.PictureBox1.Image = im;
                    paintingForm.Show();
                    UpdateImage();
                }
                catch
                {
                    MessageBox.Show("File " + s + " has a wrong format.", "Error");
                    return;
                }

                paintingForm.Text = "Image Editor - " + s;
                saveFile.FileName = Path.ChangeExtension(s, "png");
                openFile.FileName = "";
            }
        }

        public override void Close()
        {
            var result = MessageBox.Show(@"Вы действительно хотите закрыть документ?", @"Закрытие документа",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                paintingForm.Close();
            }
        }

        public override void SaveAs()
        {
            string s0 = saveFile.FileName;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string s = saveFile.FileName;
                if (s.ToUpper() == s0.ToUpper())
                {
                    s0 = Path.GetDirectoryName(s0) + "\\($$##$$).png";
                    paintingForm.PictureBox1.Image.Save(s0);
                    paintingForm.PictureBox1.Image.Dispose();
                    File.Delete(s);
                    File.Move(s0, s);
                    paintingForm.PictureBox1.Image = new Bitmap(s);
                }
                else
                    paintingForm.PictureBox1.Image.Save(s);
                paintingForm.Text = "Image Editor - " + s;
            }
        }

        public override void Clear()
        {
            UpdateImage();
            using (Graphics g = Graphics.FromImage(paintingForm.PictureBox1.Image))
                g.Clear(brush.Color);
            paintingForm.PictureBox1.Invalidate();
        }

        private void UpdateImage()
        {
            oldImage.Dispose();
            oldImage = new Bitmap(paintingForm.PictureBox1.Image);
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            movePt = startPt = e.Location;
            UpdateImage();
            if (Control.ModifierKeys == Keys.Alt)
            {
                Color c = (paintingForm.PictureBox1.Image as Bitmap).GetPixel(e.X, e.Y);
                if (e.Button == MouseButtons.Left)
                    paintingForm.LabelColor.BackColor = c;
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPt == nullPt)
                return;

            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(paintingForm.PictureBox1.Image);
                g.DrawLine(pen, startPt, e.Location);
                g.Dispose();
                startPt = e.Location;
                paintingForm.PictureBox1.Invalidate();
            }
        }

        public void ChooseColor()
        {
            colorDialog.Color = paintingForm.LabelColor.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
                pen.Color = paintingForm.LabelColor.BackColor = colorDialog.Color;
        }
    }
}
