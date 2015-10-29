using System.Windows.Forms;

namespace Mediator.Pattern
{
    class FontItalicSwitch : Widget
    {
        public RadioButton ItalicBtn { get; private set; }

        public FontItalicSwitch(RadioButton italicBtn, FontDialogDirector director)
            : base(director)
        {
            ItalicBtn = italicBtn;
        }
    }
}
