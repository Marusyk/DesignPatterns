using System.Windows.Forms;

namespace Mediator.Pattern
{
    class FontSizeSelector : Widget
    {
        public DomainUpDown DomSize { get; private set; }

        public FontSizeSelector(DomainUpDown domSize, FontDialogDirector director)
            : base(director)
        {
            DomSize = domSize;
        }
    }
}
