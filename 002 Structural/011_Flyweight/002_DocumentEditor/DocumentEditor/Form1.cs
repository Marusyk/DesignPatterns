using System.Drawing;
using System.Windows.Forms;

namespace DocumentEditor
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        GlyphFactory factory;
        GlyphContext context;

        public Form1()
        {
            InitializeComponent();

            this.graphics = this.CreateGraphics();
            this.factory = new GlyphFactory();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.context = new GlyphContext();
            this.context.SetFont(new Font("Arial", 20f));

            Glyph page = factory.CreatePage();

            Glyph column1 = factory.CreateColumn();
            column1.X = 10;
            column1.Y = 10;
            column1.Width = 380;
            column1.Height = 380;

            Glyph column2 = factory.CreateColumn();
            column2.X = 410;
            column2.Y = 10;
            column2.Width = 380;
            column2.Height = 380;

            Glyph row1 = factory.CreateRow();
            Glyph row2 = factory.CreateRow();
            Glyph row3 = factory.CreateRow();


            page.Insert(column1, null);
            page.Insert(column2, null);

            column1.Insert(row1, null);
            column1.Insert(row2, null);

            column2.Insert(row3, null);

            char[] charArray = "Abc".ToCharArray();

            foreach (var item in charArray)
                row1.Insert(factory.CreateCharacter(item), null);


            charArray = "APPARENT".ToCharArray();

            foreach (var item in charArray)
                row2.Insert(factory.CreateCharacter(item), null);


            charArray = "xyz".ToCharArray();

            foreach (var item in charArray)
                row3.Insert(factory.CreateCharacter(item), null);
            

            page.Draw(this, null);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // Form1
            this.ClientSize = new System.Drawing.Size(802, 502);
            this.Name = "Form1";
            this.Text = "Document Editor";
            this.BackColor = Color.White;
            this.ResumeLayout(false);
        }
    }
}
