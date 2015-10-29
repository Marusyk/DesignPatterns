using System;
using System.Drawing;

namespace DocumentEditor
{
    class GlyphContext
    {
        Font font;

        BTree tree;
      
        public virtual void Next(int step = 1)
        {
            throw new NotImplementedException();
        }

        public virtual void Insert(int quantity = 1)
        {
            throw new NotImplementedException();
        }

        public virtual Font GetFont()
        {
            return this.font;
        }

        public virtual void SetFont(Font font, int span = 1)
        {
            this.font = font;
        }
    }
}
