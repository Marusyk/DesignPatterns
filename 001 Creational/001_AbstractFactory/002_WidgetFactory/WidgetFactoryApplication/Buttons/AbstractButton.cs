using System.Drawing;
using System.Windows.Forms;

namespace WidgetFactoryApplication
{
    // AbstractProductA
    abstract class AbstractButton : Button
    {
        public AbstractButton()
        {
            this.Location = new Point(75, 70);
            this.Size = new Size(125, 25);
        }
    }
}
