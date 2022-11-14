using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBase2022
{
    public class ImageContainer
    {
        public string imageName;
        public Texture2D imageTexture;
        public bool isAnimated;

        ImageContainer nextImage;


        public ImageContainer()
        {
            isAnimated = false;
            nextImage = null;
        }


    }
}
