using System.Drawing;

namespace MusicNotes
{
    public class Rotate
    {
        /// <summary>
        /// Повернуть картинку.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="offset"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static Bitmap RotateImage(Image image, Point offset, float angle)
        {
            Bitmap returnBitmap = new Bitmap(image.Height, image.Width);

            Graphics g = Graphics.FromImage(returnBitmap);

            g.TranslateTransform((float)image.Width / 2, (float)image.Height / 2);

            g.RotateTransform(angle);

            g.TranslateTransform(-(float)image.Width / 2, -(float)image.Height / 2);

            g.DrawImage(image, offset);
            return returnBitmap;
        }
    }
}
