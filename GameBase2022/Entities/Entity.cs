using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBase2022
{
    internal class Entity
    {

        internal bool isActive;
        internal int uniqueId;
        
        internal bool hasCollider;
        internal Rectangle colliderBox;
        
        internal Vector2 position2D;
        internal Vector2 movement2D;

        internal string[] images;


        internal Entity nextEntity;

        internal Entity()
        {
            isActive = true;

            uniqueId = 0;

            hasCollider = false;
            colliderBox = Rectangle.Empty;
            position2D = Vector2.Zero;
            movement2D = Vector2.Zero;


            nextEntity = null;

        }



        internal virtual void Update(GameTime gameTime)
        {

        }

        internal virtual void Draw(GameTime gameTime)
        {

        }


    }
}
