using System.Drawing;

namespace WidgetFactoryApplication
{
    // ConcreteProductA2
    class LeopardButton : AbstractButton
    {
        public LeopardButton()
        {
            this.Text = "Leopard";
            this.ForeColor = Color.White;
            this.BackColor = Color.LightGray;
        }
    }
}
