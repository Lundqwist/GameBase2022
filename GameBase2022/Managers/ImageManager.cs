using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameBase2022
{
    static class ImageManager
    {

        private static ImageContainer firstImage;
        private static ImageContainer lastImage;
        internal static void Initialize()       // also used for clearing images.
        {
            firstImage = null;
            lastImage = null;
        }


        internal static void AddImage(string imageName, Texture2D imageTexture)
        {
            ImageContainer tmpImage = new ImageContainer();
            tmpImage.imageName = imageName;
            tmpImage.imageTexture = imageTexture;

            if(firstImage != null)
            {
                lastImage.nextImage = tmpImage;
                lastImage = tmpImage;
            }
            else
            {
                firstImage = tmpImage;
                lastImage = tmpImage;
            }
            
        }

        internal static void AddImage(string fileName, string imageName, Vector2 frameSize, int numberOfFrames, int animationSpeed)
        {
            ImageContainer tmpImage = new ImageContainer();
            tmpImage.imageName = imageName;
            tmpImage.imageTexture = Texture2D.FromStream(GameSystems.graphicsDeviceManager, File.OpenRead(fileName));
            tmpImage.frameSize = frameSize;
            tmpImage.animationSpeed = animationSpeed;
            tmpImage.numberOfFrames = numberOfFrames;

            if (firstImage != null)
            {
                lastImage.nextImage = tmpImage;
                lastImage = tmpImage;
            }
            else
            {
                firstImage = tmpImage;
                lastImage = tmpImage;
            }
        }

    }
}
