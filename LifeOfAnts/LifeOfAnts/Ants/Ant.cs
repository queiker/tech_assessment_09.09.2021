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
        public Position position{ get; protected set; }
        public Direction direction { get; protected set; }
        public Colony colony { get; }

        public Ant(Position position, Direction direction, Colony colony)
        {
            position = position;
            direction = direction;
            colony = colony;
        }

        public abstract void Move();
    }
}
