using System.Collections;
using System.Drawing;

namespace DocumentEditor
{
    class GlyphFactory
    {
        Hashtable flyweightPool = new Hashtable();

        // Создание разделяемых глифов.

        public Glyph CreateCharacter(char key)
        {
            if (!flyweightPool.ContainsKey(key))
                flyweightPool.Add(key, new Character(Color.DarkRed, key.ToString()));

            return flyweightPool[key] as Glyph;
        }

        // Создание не разделяемыех глифов.

        public Glyph CreatePage()
        {
            return new Page(Color.DarkOrange, 0, 0, 800, 400);
        }

        public Glyph CreateColumn()
        {
            return new Column(Color.Gray, 10, 10, 380, 380);
        }

        public Glyph CreateRow()
        {
            return new Row(Color.Green, 360, 50);
        }
    }
}
