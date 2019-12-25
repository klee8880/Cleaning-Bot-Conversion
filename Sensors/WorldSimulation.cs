using System;
using System.Collections.Generic;
using System.Text;

namespace Cleaning_Bot_Conversion.Sensors
{
    public class WorldSimulation
    {
        private static WorldSimulation Sim;

        public static WorldSimulation getInstance()
        {
            if (Sim == null) Sim = new WorldSimulation();

            return Sim;
        }
    }
}
