using GameBase2022.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBase2022
{
    internal static class GameSystems
    {
        internal static GraphicsDeviceManager graphicsDeviceManager;
        internal static SpriteBatch spriteBatch;
        internal static Game game;
        internal static void Initialize(Game1 game1)
        {
            graphicsDeviceManager = new GraphicsDeviceManager(game1);

            TimeManager.Initialize();
            game = game1;
        }


    }
}
