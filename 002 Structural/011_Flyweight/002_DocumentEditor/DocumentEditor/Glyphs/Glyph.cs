using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

// Глиф - это объект, обладающий графическим атрибутами и умеющий изображать себя.

namespace DocumentEditor
{
    abstract class Glyph
    {
        protected Graphics graphics;
        protected List<Glyph> glyphs;

        public int X { get; set; }
        public int Y { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public Color Color { get; set; }
        
        public abstract void Draw(Form window, GlyphContext context);
        public abstract void SetFont(Font font, GlyphContext context);
        public abstract Font GetFont(GlyphContext context);
        public abstract void First(GlyphContext context);
        public abstract void Next(GlyphContext context);
        public abstract bool IsDone(GlyphContext context);
        public abstract Glyph Current(GlyphContext context);

        public abstract void Insert(Glyph glyph, GlyphContext context);
        public abstract void Remove(GlyphContext context);
    }
}
