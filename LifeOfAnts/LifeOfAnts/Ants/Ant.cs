using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeOfAnts.Ants;
using LifeOfAnts.ExtensionMethods;
using LifeOfAnts.Utilities;
using LifeOfAnts;

namespace LifeOfAnts.Ants
{
    public abstract class Ant
    {
        public Position Position { get; protected set; }
        public Direction Direction { get; protected set; }
        public Colony Colony { get; }

        public Ant(Position position, Direction direction, Colony colony)
        {
            Position = position;
            Direction = direction;
            Colony = colony;
        }

        public abstract void Move();
    }
}
