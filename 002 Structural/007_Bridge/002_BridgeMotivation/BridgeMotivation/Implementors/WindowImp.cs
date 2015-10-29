using System.Windows.Forms;

namespace WidgetFactoryApplication
{
    // Implementor
    abstract class WindowImp
    {
        protected Button button;
        protected Form form;

        public abstract Form DevDrawForm();
        public abstract Button DevDrawButton();
    }
}
