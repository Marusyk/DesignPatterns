using System.Drawing;

namespace FigureManipulators
{
    class TextFigure : Figure
    {
        // Положение фигуры на форме.
        Point startPoint;

        public TextFigure(Point startPoint)
        {
            this.startPoint = startPoint;
            manipulator = CreateManipulator();
        }

        // Фабричный метод возвращающий манипулятор соответствующий данной фигуре.
        public override Manipulator CreateManipulator()
        {
            return new TextManipulator(startPoint);
        }
    }
}
