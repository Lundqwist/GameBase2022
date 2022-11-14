using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBase2022
{
    static class ImageManager
    {

        public static Texture2D[] texture2DImages;
        static int currentImagePosition;

        public static void AddImage(string imageName)
        {
            ImageContainer tmpImage = new ImageContainer();
            tmpImage.imageName = imageName;
            
        }

    }
}
