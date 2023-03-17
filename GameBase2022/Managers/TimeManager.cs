using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBase2022.Managers
{
    internal static class TimeManager
    {
        static Timers firstTimer;


        internal static void Initialize()
        {
            firstTimer = null;
        }

        public static bool AddTimer(string nameOfTimer, int startValue)
        {
            Timers tmpTimer = new Timers(nameOfTimer, startValue);
            Timers stepTimer = firstTimer;

            if (firstTimer != null)
            {
                while (stepTimer.nextTimer != null)
                {
                    if (stepTimer.nameOfTimer != nameOfTimer)
                    {
                        stepTimer = stepTimer.nextTimer;
                    }
                    else
                    {
                        return false;
                    }
                }
                stepTimer.nextTimer = tmpTimer;
            }
            else
            {
                firstTimer = tmpTimer;
            }
            return true;
        }

        public static int GetTime(string nameOfTimer)
        {
            Timers stepTimer = firstTimer;

            while (stepTimer.nameOfTimer != nameOfTimer && stepTimer != null)
            {
                stepTimer = stepTimer.nextTimer;
            }

            if (stepTimer != null)
            {
                return stepTimer.elapsedTime;
            }
            else
            {
                return 0;
            }
        }

        public static void UpdateTimers(GameTime gameTime)
        {
            Timers stepTimer = firstTimer;

            while (stepTimer != null)
            {
                stepTimer.elapsedTime += gameTime.ElapsedGameTime.Milliseconds;
                stepTimer = stepTimer.nextTimer;
            }
        }

        public static bool SetTimer(string nameOfTimer, int value)
        {
            Timers stepTimer = firstTimer;
            while (stepTimer.nameOfTimer != nameOfTimer && stepTimer != null)
            {
                stepTimer = stepTimer.nextTimer;
            }

            if (stepTimer != null)
            {
                stepTimer.elapsedTime = value;
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
