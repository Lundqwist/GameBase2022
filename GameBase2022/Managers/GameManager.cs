using GameBase2022.Managers;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBase2022
{
    internal static class GameManager
    {
        internal static void LoadLevel(int level)
        {

        }

        internal static void Initialize()
        {
            
            TimeManager.AddTimer("AFKTimer", 0);
        }



        internal static void Update(GameTime gameTime)
        {
            TimeManager.UpdateTimers(gameTime);

            GameSystems.game.Window.Title = "Time until AFK-Exit: " + ((int)((6000 - TimeManager.GetTime("AFKTimer"))/1000)).ToString() ;
            if(TimeManager.GetTime("AFKTimer") > 6000)
            {
                GameSystems.game.Exit();
            }


        }


        
    } 
}
