using System.Windows.Forms;

namespace TextViewDecorator
{
    public class BorderDecorator : Decorator
    {

        public BorderDecorator(Form form, TextBox textBox)
            : base(form, textBox)
        {
        }

        public override void Draw()
        {
            base.Draw();
            DrawBorder();
        }

        public void DrawBorder()
        {
            TextBox.BorderStyle=BorderStyle.FixedSingle;
        }
    }
}
