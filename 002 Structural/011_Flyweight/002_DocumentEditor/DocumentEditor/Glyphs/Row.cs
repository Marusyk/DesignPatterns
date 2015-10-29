using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DocumentEditor
{
    // Row - не разделяемый глиф.
    class Row : Glyph
    {
        int actualWidthRow = 0;

        public Row(Color color, int width, int height)
        {
            this.Color = color;

            this.Width = width;
            this.Height = height;

            this.glyphs = new List<Glyph>();
        }

        public override void Draw(Form window, GlyphContext context)
        {
            int currentX = this.X;
            int currentY = this.Y;

            int maxSize = 0;

            foreach (var character in this.glyphs)
            {
                character.X = currentX;
                character.Y = currentY;

                currentX += character.Width;

                if (maxSize < character.Height)
                    this.Height = maxSize = character.Height;

                this.Height = character.Height;

                character.Draw(window, context);
            }

            this.graphics = window.CreateGraphics();
            this.graphics.DrawRectangle(new Pen(this.Color, 1),
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
            if (glyph is Character)
            {
                if (this.actualWidthRow + glyph.Width > this.Width)
                    throw new ArgumentOutOfRangeException("Помещаемый символ не помещается в строку.");

                this.actualWidthRow += glyph.Width;
                this.glyphs.Add(glyph);
            }
            else
                throw new ArgumentException("В строку допустимо помещать только символы - Character");
        }

        public override void Remove(GlyphContext context)
        {
            throw new NotImplementedException();
        }
    }
}
