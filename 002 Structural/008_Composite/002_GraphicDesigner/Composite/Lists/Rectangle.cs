using System.Drawing;

namespace Composite
{
    class Rectangle : IGraphic
    {
        Point point;
        Size size;
        Color color;

        public Rectangle(Color color, int x, int y, int width, int height)
        {
            this.color = color;
            this.point = new Point(x, y);
            this.size = new Size(width, height);
        }

        public void Draw(Graphics device)
        {
            device.DrawRectangle(new Pen(this.color, 5),
                new System.Drawing.Rectangle(point, size));
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
