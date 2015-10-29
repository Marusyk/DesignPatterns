using System.Drawing;

namespace FigureManipulators
{
    class LineFigure : Figure
    {
        // Положение фигуры на форме.
        Point endPoint;
        Point startPoint;

        public LineFigure(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            manipulator = CreateManipulator();
        }

        // Фабричный метод возвращающий манипулятор соответствующий данной фигуре.
        public override Manipulator CreateManipulator()
        {
            return new LineManipulator(startPoint, endPoint);
        }
    }
}
