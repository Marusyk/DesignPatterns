using System.Drawing;

namespace Adapter
{
    class Line : Shape
    {
        // Начальные координаты линии на форме
        Point endPoint;
        Point startPoint;
        Pen color;

        public Line(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        public override void BoundingBox()
        {
            color = new Pen(Brushes.Blue, 3);    
        }

        // Фабричный метод возвращающий манипулятор соответсвующий конкретной фигуре
        public override Manipulator CreateManipulator()
        {
            return new LineManipulator(startPoint, endPoint, color);
        }
    }
}
