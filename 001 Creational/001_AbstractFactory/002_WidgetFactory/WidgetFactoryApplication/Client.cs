using System.Windows.Forms;

namespace WidgetFactoryApplication
{
    // Client
    class Client
    {
        AbstractWindow window;
        AbstractButton button;

        public Client(WidgetFactory factory)
        {
            window = factory.CreateWindow();
            button = factory.CreateButton();
        }

        public Form GetForm()
        {
            window.AddToCollection(button);
            return window;
        }
    }
}
