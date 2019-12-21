using System;
using System.Collections.Generic;

namespace Cleaning_Bot_Conversion.Navigation
{
    public class InternalPath
    {
        private Stack<Coordinates> Path;
        public float TotalCost { get; set; }

        public InternalPath()
        {
            Path = new Stack<Coordinates>();
        }

        //Stack Manipulation
        public void Push(Coordinates next) => Path.Push(next);
        public Coordinates Pop() => Path.Pop();
        public Coordinates Peek() => Path.Peek();
        public bool IsEmpty() => Path.Count <= 0;

        public Stack<Coordinates> GetPath()
        /**
         * Get a copy of the visited locations in the reverse order they where stored in.
         */
        {
            Stack<Coordinates> newPath = new Stack<Coordinates>();
            foreach (Coordinates c in Path) newPath.Push(c);
            return newPath;
        }
            
        public Stack<Direction> GetDirections()
        {
            Stack<Direction> stack = new Stack<Direction>();

            //Get a manipulatable copy of the stack
            Coordinates [] record = new Coordinates[Path.Count];
            Path.CopyTo(record,0);


            int index = 0;
            while (index < Path.Count)
            {
                Coordinates current = record[index];

                if (index + 1 < Path.Count)
                {
                    Coordinates prev = record[index + 1];

                    if (current.X == prev.X){
                        if (current.Y < prev.Y) stack.Push(Direction.South);
                        else stack.Push(Direction.North);
                    }
                    else if (current.Y == prev.Y){
                        if (current.X < prev.X) stack.Push(Direction.West);
                        else stack.Push(Direction.East);
                    }
                }

                index++;
            }

            return stack;
        }
    }
}
