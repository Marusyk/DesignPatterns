using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DocumentEditor
{
    // Column - не разделяемый глиф.
    class Column : Glyph
    {
        public Column(Color color, int x, int y, int width, int height)
        {
            this.Color = color;

            this.X = x;
            this.Y = y;

            this.Width = width;
            this.Height = height;

            this.glyphs = new List<Glyph>();
        }

        public override void Draw(Form window, GlyphContext context)
        {
            int currentX = this.X + 5;
            int currentY = this.Y + 5;

            foreach (var row in this.glyphs)
            {
                row.X = currentX;
                row.Y = currentY;

                currentY += row.Height;

                row.Width = this.Width - 10;

                row.Draw(window, context);
            }

            this.graphics = window.CreateGraphics();
            this.graphics.DrawRectangle(new Pen(this.Color, 2),
                    new Rectangle(new Point(this.X, this.Y), new Size(this.Width, this.Height)));
        }

        public override void SetFont(Font font, GlyphContext context)
        {
            throw new NotImplementedException();
        }

        public override Font GetFont(GlyphContext context)
        {
            throw new NotImplementedException();
        }

        public override void First(GlyphContext context)
        {
            throw new NotImplementedException();
        }

        public override void Next(GlyphContext context)
        {
            throw new NotImplementedException();
        }

        public override bool IsDone(GlyphContext context)
        {
            throw new NotImplementedException();
        }

        public override Glyph Current(GlyphContext context)
        {
            throw new NotImplementedException();
        }

        public override void Insert(Glyph glyph, GlyphContext context)
        {
            if (glyph is Row)
            {
                this.glyphs.Add(glyph);
            }
            else
                throw new ArgumentException("В столбец допустимо помещать только строки - Row");
        }

        public override void Remove(GlyphContext context)
        {
            throw new NotImplementedException();
        }
    }
}
