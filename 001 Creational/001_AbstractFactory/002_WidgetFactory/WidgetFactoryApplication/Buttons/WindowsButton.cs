using System.Drawing;

namespace WidgetFactoryApplication
{
    // ConcreteProductA1
    class WindowsButton : AbstractButton
    {
        public WindowsButton()
        {
            this.Text = "Windows";
            this.ForeColor = Color.Aqua;
            this.BackColor = Color.DarkBlue;
        }
    }
}
