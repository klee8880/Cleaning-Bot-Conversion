using System;
using System.Collections.Generic;
using System.Text;
using Cleaning_Bot_Conversion.Navigation;

namespace Cleaning_Bot_Conversion.Sensors
{
    public class Sensor : ISensorPackage
    {
        public void CleanTile(Coordinates target)
        {
            throw new NotImplementedException();
        }

        public bool CollisionEast(Coordinates current)
        {
            throw new NotImplementedException();
        }

        public bool CollisionNorth(Coordinates current)
        {
            throw new NotImplementedException();
        }

        public bool CollisionSouth(Coordinates current)
        {
            throw new NotImplementedException();
        }

        public bool CollisionWest(Coordinates current)
        {
            throw new NotImplementedException();
        }

        public bool DirtDetected(Coordinates current)
        {
            throw new NotImplementedException();
        }

        public Coordinates[] StationsDetected()
        {
            throw new NotImplementedException();
        }
    }
}
