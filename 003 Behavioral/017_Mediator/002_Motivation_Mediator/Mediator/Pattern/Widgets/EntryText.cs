using System.Drawing;
using System.Windows.Forms;

namespace Mediator.Pattern
{
    class EntryText : Widget
    {
        Label textWidget;

        public EntryText(Label bindedWidget, FontDialogDirector director)
            : base(director)
        {
            textWidget = bindedWidget;
        }

        public void changeTextFontFam(string fontFamily)
        {
            textWidget.Font = new Font(fontFamily, textWidget.Font.Size, textWidget.Font.Style);
        }

        internal void SetFontSize(int p)
        {
            textWidget.Font = new Font(textWidget.Font.FontFamily.Name, p, textWidget.Font.Style);
        }

        internal void SetFontStrikeOut(bool flag)
        {
            if (flag)
                textWidget.Font = new Font(textWidget.Font.FontFamily.Name, textWidget.Font.Size, textWidget.Font.Style | FontStyle.Strikeout);
            else
                textWidget.Font = new Font(textWidget.Font.FontFamily.Name, textWidget.Font.Size, textWidget.Font.Style ^ FontStyle.Strikeout);
        }

        internal void SetFontBold(bool flag)
        {
            if (flag)
                textWidget.Font = new Font(textWidget.Font.FontFamily.Name, textWidget.Font.Size, textWidget.Font.Style | FontStyle.Bold);
            else
                textWidget.Font = new Font(textWidget.Font.FontFamily.Name, textWidget.Font.Size, textWidget.Font.Style ^ FontStyle.Bold);
        }

        internal void SetFontItalic(bool flag)
        {
            if (flag)
                textWidget.Font = new Font(textWidget.Font.FontFamily.Name, textWidget.Font.Size, textWidget.Font.Style | FontStyle.Italic);
            else
                textWidget.Font = new Font(textWidget.Font.FontFamily.Name, textWidget.Font.Size, textWidget.Font.Style ^ FontStyle.Italic);
        }
    }
}
