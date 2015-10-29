using System;
using System.Windows.Forms;

namespace WidgetFactoryApplication
{
    // Client
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Window window = null;

            //window = new MSWindow();
            window = new MacWindow();

            window.Draw();
        }
    }
}
