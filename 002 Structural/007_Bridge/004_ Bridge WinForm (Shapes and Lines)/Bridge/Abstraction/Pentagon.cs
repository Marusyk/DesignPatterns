using System.Drawing;
using System.Windows.Forms;

namespace Bridge
{
    class Pentagon : Shape
    {
        // Создать массив точек
        Point[] points = new Point[]
        { 
            new Point(10, 10), 
            new Point(10, 100), 
            new Point(50, 65), 
            new Point(100, 100), 
            new Point(85, 40)          
        };

        public override void Draw(Form form, Color color)
        {
            base.Draw(form, color);

            // Нарисовать фигуру.            
            this.graphics.DrawPolygon(pen, points);
        }
    }
}
