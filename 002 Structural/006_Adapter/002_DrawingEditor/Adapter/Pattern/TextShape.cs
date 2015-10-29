using System.Drawing;
using System.Windows.Forms;

namespace Adapter
{
    /// <summary>
    /// Класс TextShape - адаптер, который адаптирует интерфейс TextView к интерфейсу Shape
    /// </summary>
    class TextShape : Shape
    {
        Point startPoint;
        string text;
        TextView textView;
        Label label;

        public TextShape(Point startPoint, string text)
        {
            textView = new TextView();
            this.startPoint = startPoint;
            this.text = text;
        }

        // Преобразование запроса BoundingBox в запрос GetExtend.
        public override void BoundingBox()
        {
            label = textView.GetExtend();
            label.Text = text;
        }

        // Фабричный метод, возвращающий манипулятор соответсвующий конкретной фигуре
        public override Manipulator CreateManipulator()
        {
            return new TextManipulator(startPoint, label);
        }
    }
}
