using System.Windows.Forms;

namespace TextViewDecorator
{
    public partial class Form1 : Form
    {
        private TextBox textBox;

        private TextView textView;
        private BorderDecorator borderDecorator;
        private ScrollDecorator scrollDecorator;

        public Form1()
        {
            InitializeComponent();
            textBox = new TextBox();
            textBox.BorderStyle = BorderStyle.None;
        }

        private void CloseSolution(object sender, System.EventArgs e)
        {
            Close();
        }

        private void AddTextView(object sender, System.EventArgs e)
        {
            textView = new TextView(this, textBox);
            textView.Draw();
        }

        private void AddBorder(object sender, System.EventArgs e)
        {
            if (textView == null) return;
            borderDecorator = new BorderDecorator(this, textBox);

            if (scrollDecorator != null)
            {
                borderDecorator.SetComponent(scrollDecorator);
            }
            else if (textView != null)
            {
                borderDecorator.SetComponent(textView);
            }

            borderDecorator.Draw();
        }

        private void AddScroll(object sender, System.EventArgs e)
        {
            if (textView == null) return;
            scrollDecorator = new ScrollDecorator(this, textBox);

            if (borderDecorator != null)
            {
                scrollDecorator.SetComponent(borderDecorator);
            }
            else if (textView != null)
            {
                scrollDecorator.SetComponent(textView);
            }

            scrollDecorator.Draw();
        }
    }
}
