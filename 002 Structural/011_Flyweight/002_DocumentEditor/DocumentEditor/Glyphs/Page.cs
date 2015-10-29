using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DocumentEditor
{
    // Page - не разделяемый глиф.
    class Page : Glyph
    {
        Point point;
        Size size;
        Color color;
        Font font;

        public Page(Color color, int x, int y, int width, int height)
        {
            this.color = color;
            this.point = new Point(x, y);
            this.size = new Size(width, height);
            this.glyphs = new List<Glyph>();
        }

        public override void Draw(Form window, GlyphContext context)
        {
            this.graphics = window.CreateGraphics();
            this.graphics.DrawRectangle(new Pen(this.color, 5), new Rectangle(point, size));

            foreach (var glyph in this.glyphs)
            {
                glyph.Draw(window, context);
            }
        }

        public override void SetFont(Font font, GlyphContext context)
        {
            this.font = font;
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
            if (glyph is Column)
            {
                if (this.glyphs.Count < 2)
                {
                   
                    this.glyphs.Add(glyph);

                }

            }
            else
                throw new ArgumentException("В страницу допустимо помещать только столбцы - Column ");
        }

        public override void Remove(GlyphContext context)
        {
            throw new NotImplementedException();
        }
    }
}
