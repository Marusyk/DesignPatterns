using System.Windows.Forms;

namespace Mediator.Pattern
{
    class FontBox : Widget
    {
        public TextBox textBoxWidget { get; private set; }

        public FontBox(TextBox bindedWidget, FontDialogDirector director)
            : base(director)
        {
            textBoxWidget = bindedWidget;
        }

        public void SetFontName(string fontFamily)
        {
            textBoxWidget.Text = fontFamily;
        }
    }
}
