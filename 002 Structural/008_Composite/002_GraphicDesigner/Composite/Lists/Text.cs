using System;
using System.Drawing;

namespace Composite
{
    class Text : IGraphic
    {
        Font font;
        Brush brush;
        Color color;
        string text;
        int x, y;

        public Text(Color color, string text, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            this.text = text;
            this.font = new Font("Arial", 20f);
            this.brush = new SolidBrush(Color.Gray);
        }

        public void Draw(Graphics device)
        {
            device.DrawString(text, font, brush, this.x, this.y);
        }

        public void Add(IGraphic graphic)
        {
            throw new InvalidOperationException();
        }

        public void Remove(IGraphic graphic)
        {
            throw new InvalidOperationException();
        }

        public IGraphic GetChild(int child)
        {
            throw new InvalidOperationException();
        }
    }
}
