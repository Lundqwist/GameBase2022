﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBase2022
{
    static internal class GameSystems
    {
        static internal GraphicsDeviceManager graphicsDeviceManager;
        static internal SpriteBatch spriteBatch;
        internal static void Initialize(Game1 game1)
        {
            graphicsDeviceManager = new GraphicsDeviceManager(game1);



        }


    }
}
