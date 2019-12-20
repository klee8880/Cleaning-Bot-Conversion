using System;
using System.Collections.Generic;

namespace Cleaning_Bot_Conversion.Navigation
{
    class InternalPath
    {
        public Stack<Coordinates> Path;
        private float totalCost { get; set; }

        public InternalPath()
        {
            Path = new Stack<Coordinates>();
        }

        //Stack Manipulation
        public void Push(Coordinates next) => Path.Push(next);
        public Coordinates Pop() => Path.Pop();
        public Coordinates Peek() => Path.Peek();
        public bool IsEmpty() => Path.Count <= 0;
    }
}
