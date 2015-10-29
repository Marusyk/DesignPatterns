using System.Drawing;
using System.Windows.Forms;

namespace Composite
{
    public class Form1 : Form
    {
        Graphics graphics;
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Composite";
            this.BackColor = Color.White; 
            this.graphics = this.CreateGraphics();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Picture root = new Picture();
            Picture branch = new Picture();
            Line lineA = new Line(Color.Brown, 10, 150, 258, 150);
            Line lineB = new Line(Color.Yellow, 30, 100, 240, 100);
            Rectangle rectangleA = new Rectangle(Color.Green, 10, 10, 250, 250);
            Rectangle rectangleB = new Rectangle(Color.LightGreen, 30, 30, 208, 100);
            Text text = new Text(Color.LightGray, "Hello!", 90, 50);

            root.Add(branch);
            root.Add(lineA);
            root.Add(rectangleA);

            branch.Add(lineB);
            branch.Add(rectangleB);
            branch.Add(text);

            root.Draw(this.graphics);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(272, 271);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
