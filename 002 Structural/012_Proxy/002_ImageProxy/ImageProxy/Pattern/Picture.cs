using System;
using System.Drawing;

namespace ImageProxy.Pattern
{
    class Picture : Graphic
    {
        public Picture(string fileName)
        {
            this.fileName = fileName;
        }

        public override void Draw()
        {
            PictureToShow = Image.FromFile(fileName);
        }

        public override void Load()
        {
            throw new InvalidOperationException();
        }
    }
}
