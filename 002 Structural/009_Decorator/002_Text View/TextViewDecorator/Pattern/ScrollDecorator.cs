using System.Windows.Forms;


namespace TextViewDecorator
{
    public class ScrollDecorator : Decorator
    {

        public ScrollDecorator(Form form, TextBox textBox)
            : base(form, textBox)
        {
        }

        public void ScrollTo()
        {
            TextBox.Multiline = true;
            TextBox.Height = Form.Height - 100;
            TextBox.ScrollBars = ScrollBars.Vertical;
        }

        public override void Draw()
        {
            base.Draw();
            ScrollTo();
        }
    }
}
