using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBase2022
{
    internal class ImageContainer
    {
        internal string imageName;
        internal Texture2D imageTexture;

        internal bool isAnimated;
        internal Vector2 frameSize; // storlek för en frame i animation.
        internal int animationSpeed;
        internal int currentFrame;
        internal int numberOfFrames;
        

        internal ImageContainer()
        {
            isAnimated = false;
        }
    }
}
