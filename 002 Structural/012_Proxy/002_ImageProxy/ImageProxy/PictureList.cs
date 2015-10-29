using System.Collections.Generic;
using ImageProxy.Pattern;

namespace ImageProxy
{
    class PictureList
    {
       public static List<Graphic> listPictures { get; set; }

       static PictureList()
       {
           listPictures = new List<Graphic>();
       }
    }
}
