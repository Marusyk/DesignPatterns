using System.Drawing;

namespace ImageProxy.Pattern
{
    abstract class Graphic
    {
        public string fileName;
        abstract public void Draw();
        abstract public void Load();

        public Image PictureToShow { get; set; }
    }
}
