using System;
using System.Collections.Generic;
using System.Text;

namespace Cleaning_Bot_Conversion.Robotics
{
    public class Hardware
    {

        public float DUSTCAPACITY { get; }
        public float BATTERYCAPACITY { get; }
        public float Battery { get; set; }
        public float Dust { get; set; }
        protected int buffer = 5;

        public Hardware(float DustCapacity, float BatteryCapacity)
        {
            //Sanitization
            if (DustCapacity <= 0) throw new ArgumentException($"Dust Capacity cannot be < 0 ({DustCapacity}).");
            else if (BatteryCapacity <= 0) throw new ArgumentException($"Battery Capacity cannot be < 0 ({BatteryCapacity}).");

            this.DUSTCAPACITY = DustCapacity;
            this.BATTERYCAPACITY = BatteryCapacity;
            this.Dust = 0;
            this.Battery = BatteryCapacity;
        }

        /**
         * incriment the battery capacity and return whether batter ins at capacity
         */
        public void IncrimentBattery(float delta)
        {
            Battery += delta;
        }

        public void IncrimentDust(float delta)
        {
            Dust += delta;
        }

        //public bool BatteryAtCapacity() = () => 

    }
}
