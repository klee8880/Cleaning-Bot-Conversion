using System;
using System.Collections.Generic;
using System.Text;

namespace Cleaning_Bot_Conversion.Navigation
{
    class MapTile
    {
        public TileType TerrainType;
        public TileSide NorthSide;
        public TileSide EastSide;
        public TileSide SouthSide;
        public TileSide WestSide;
        public Coordinates Coords {
            get {
                return Coords.Clone();
            }
            set {
                Coords = value.Clone();
            }
        }
        public int DirtVal;

        //Constructors
        public MapTile(int dirt, TileType tType, Coordinates coords)
        {
            DirtVal = dirt;
            TerrainType = tType;
            Coords = coords.Clone();
        }

        public MapTile(int dirt, TileType tType, int xPos, int yPos)
        {
            DirtVal = dirt;
            TerrainType = tType;
            Coords = new Coordinates(xPos, yPos);
        }
        public MapTile(int dirt, TileType tType, int xPos, int yPos, TileSide nS, TileSide eS, TileSide sS, TileSide wS)
        {
            DirtVal = dirt;
            TerrainType = tType;

            Coords = new Coordinates(xPos, yPos);

            NorthSide = nS;
            EastSide = eS;
            SouthSide = sS;
            WestSide = wS;
        }
        public MapTile(int dirt, TileType tType, Coordinates coords, TileSide nS, TileSide eS, TileSide sS, TileSide wS)
        {
            DirtVal = dirt;
            TerrainType = tType;

            Coords = coords.Clone();

            NorthSide = nS;
            EastSide = eS;
            SouthSide = sS;
            WestSide = wS;
        }

        //Functions
        public void RemoveDirt(Coordinates coords)
        {
            DirtVal = 0;
        }

        public bool HasObstacle(Direction dir)
        {
            TileSide side;

            switch (dir)
            {
                case Direction.North:
                    side = this.NorthSide;
                case Direction.East:
                    side = this.EastSide;
                case Direction.South:
                    side = this.SouthSide;
                case Direction.West
                    side = this.WestSide;
                default:
                    throw new Exception("Unsupported direction indicator given");
            }

            return side == TileSide.DOOR_OPEN || side == TileSide.PASSABLE 
            
        }
    }
}
