using System.Windows.Forms;

namespace Mediator.Pattern
{
    class FontBoldSwitch : Widget
    {
        public RadioButton BoldBtn { get; private set; }

        public FontBoldSwitch(RadioButton boldBtn, FontDialogDirector director)
            : base(director)
        {
            BoldBtn = boldBtn;
        }
    }
}
