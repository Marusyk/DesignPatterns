using System;
using System.Drawing;
using System.Windows.Forms;

namespace DocumentEditor
{
    // Character - разделяемый глиф.
    class Character : Glyph
    {
        Font font;
        Brush brush;
        string character;

        GlyphContext context;

        float fontSize = 20f;

        public Character(Color color, string letter)
        {
            this.Color = color;

            this.character = letter;

            this.font = new Font("Arial", this.fontSize);

            this.Width = (int)this.fontSize; //font.Width
            this.Height = this.font.Height;

            this.brush = new SolidBrush(this.Color);
        }

        public override void Draw(Form window, GlyphContext context)
        {
            this.graphics = window.CreateGraphics();
            this.graphics.DrawString(character, font, brush, this.X, this.Y);
        }

        public override void SetFont(Font font, GlyphContext context)
        {
            this.context = context;
        }

        public override Font GetFont(GlyphContext context)
        {
            return context.GetFont();
        }

        #region Unused methods

        public override void First(GlyphContext context)
        {
            throw new InvalidOperationException();
        }

        public override void Next(GlyphContext context)
        {
            throw new InvalidOperationException();
        }

        public override bool IsDone(GlyphContext context)
        {
            throw new InvalidOperationException();
        }

        public override Glyph Current(GlyphContext context)
        {
            throw new InvalidOperationException();
        }

        public override void Insert(Glyph glyph, GlyphContext context)
        {
            throw new InvalidOperationException();
        }

        public override void Remove(GlyphContext context)
        {
            throw new InvalidOperationException();
        }

        #endregion
    }
}
