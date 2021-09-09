using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeOfAnts.Utilities
{
    public struct Position
    {
        public int X { get; }
        public int Y { get; }
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if(obj is Position position)
            {
                return this.X == Position.X && this.Y == position.Y;
            }
            else
            {
                return false;
            }
            
        }

        public static Position Zero => new Position(0, 0);

    }
}
