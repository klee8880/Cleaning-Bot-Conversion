using System;
using Cleaning_Bot_Conversion.Navigation;

namespace Cleaning_Bot_Conversion.Sensors
{
    public interface ISensorPackage
    {
        bool CollisionNorth(Coordinates current);
        bool CollisionEast(Coordinates current);
        bool CollisionSouth(Coordinates current);
        bool CollisionWest(Coordinates current);
        bool DirtDetected(Coordinates current);
        Coordinates[] StationsDetected();
        void CleanTile(Coordinates target);

    }
}
