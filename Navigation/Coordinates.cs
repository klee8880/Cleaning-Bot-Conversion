using System;
using System.Collections.Generic;
using System.Text;

namespace Cleaning_Bot_Conversion.Navigation
{
    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinates() { }

        public Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(object right)
        {
            if (this == right) return true;

            if (!(right is Coordinates)) return false;

            return ((Coordinates)right).X == this.X && ((Coordinates)right).Y == this.Y;
        }

        public Coordinates NorthOf()
        {
            return new Coordinates(this.X, this.Y + 1);
        }

        public Coordinates EastOf()
        {
            return new Coordinates(this.X + 1, this.Y);
        }

        public Coordinates SouthOf()
        {
            return new Coordinates(this.X, this.Y - 1);
        }

        public Coordinates WestOf()
        {
            return new Coordinates(this.X - 1, this.Y);
        }

        public Coordinates Clone()
        {
            return new Coordinates(this.X, this.Y);
        }

        public override string ToString()
        {
            //return "(" + this.x + ", " + this.y + ")";
            return $"({this.X}, {this.Y})";
        }

        public override int GetHashCode()
        {
            return (this.X * 97 + this.Y) * 97;
        }

        public Boolean AdjacentTo(Coordinates target)
        {
            if (this == target)
                return false;
            else if (this.X == target.X && Math.Abs(this.Y - target.Y) == 1)
                return true;
            else if (this.Y == target.Y && Math.Abs(this.X - target.X) == 1)
                return true;
            else
                return false;
        }

    }
}
