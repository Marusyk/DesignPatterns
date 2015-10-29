using System.Windows.Forms;

namespace Mediator.Pattern
{
    class MyListBox : Widget
    {
        public ListBox listBoxWidget { get; private set; }

        public MyListBox(ListBox bindedWidget, FontDialogDirector director)
            : base(director)
        {
            listBoxWidget = bindedWidget;
        }

        internal void FindFontFamily(string p)
        {
            listBoxWidget.SelectedIndex = listBoxWidget.FindString(p);
        }
    }
}
