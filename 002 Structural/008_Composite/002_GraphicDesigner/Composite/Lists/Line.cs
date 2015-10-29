using System.Drawing;
using System.Drawing.Drawing2D;

namespace Composite
{
    class Line : IGraphic
    {
        Point a;
        Point b;
        Color color;

        public Line(Color color, int x1, int y1, int x2, int y2)
        {
            this.color = color;
            this.a = new Point(x1, y1);
            this.b = new Point(x2, y2);
        }

        public void Draw(Graphics device)
        {
            device.DrawLine(new Pen(color, 5), a, b);
        }

        public void Add(IGraphic graphic)
        {
            throw new System.InvalidOperationException();
        }

        public void Remove(IGraphic graphic)
        {
            throw new System.InvalidOperationException();
        }

        public IGraphic GetChild(int child)
        {
            throw new System.InvalidOperationException();
        }
    }
}
