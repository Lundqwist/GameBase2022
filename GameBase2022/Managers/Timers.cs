using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBase2022
{
    internal class Timers
    {
        internal int elapsedTime;
        internal string nameOfTimer;

        internal Timers nextTimer;

        internal Timers(string nameOfTimer, int startValue)
        {
            elapsedTime = startValue;
            this.nameOfTimer = nameOfTimer;
            nextTimer = null;
        }



        //internal static Dictionary<string, DateTime> longTimers;

        //internal static void Initialize()
        //{
        //    longTimers = new Dictionary<string, DateTime>();
        //}
        //internal static void AddTimer(string nameOfTimer)
        //{

        //    longTimers.Add(nameOfTimer, DateTime.Now);
        //}

        //internal static int GetTimer(string nameOfTimer)
        //{
        //    int tmpTimer = 0;
        //    DateTime tmpTime;
        //    if(longTimers.TryGetValue(nameOfTimer, out tmpTime))
        //    {

        //        tmpTimer = tmpTime - DateTime.Now;5
        //    }
        //    return tmpTimer;
        //}

        //internal static void ResetTimer(string nameOfTimer)
        //{
        //    longTimers.Remove(nameOfTimer);
        //    longTimers.Add(nameOfTimer, DateTime.Now);
        //}

        //internal static void RemoveTimer(string nameOfTimer)
        //{
        //    longTimers.Remove(nameOfTimer);
        //}
    }
}
