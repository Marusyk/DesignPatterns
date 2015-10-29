using System.Drawing;
using ImageProxy.Properties;

namespace ImageProxy.Pattern
{
    class PictureProxy : Graphic
    {
        Picture picture;

        public PictureProxy(string fileName)
        {
            this.fileName = fileName;
            PictureToShow = new Bitmap(Resources.startImg, 52, 62);
        }

        public override void Draw()
        {
            if (picture == null)
            {
                picture = new Picture(fileName);
            }
            picture.Draw();
        }
        
        public override void Load()
        {
            PictureList.listPictures[PictureList.listPictures.IndexOf(this)] = this.picture;
        }
    }
}
