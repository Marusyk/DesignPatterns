using System.Windows.Forms;

namespace Mediator.Pattern
{
    class FontCondensedIndicator : Widget
    {
        public CheckBox CondensedIndicator { get; private set; }

        public FontCondensedIndicator(CheckBox condensedIndicator, FontDialogDirector director)
            : base(director)
        {
            CondensedIndicator = condensedIndicator;
        }
    }
}
