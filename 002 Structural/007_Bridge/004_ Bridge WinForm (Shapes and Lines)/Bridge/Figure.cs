using System.Drawing;
using System.Windows.Forms;

namespace Bridge
{
    // "Client"
    class Figure
    {
        public static void Draw(Form form, Shape shape, LineStyle line, Color color)
        {
            shape.implementor = line;
            shape.Draw(form, color);
        }
    }
}
