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
    public class Worker : Ant
    {
        public Worker(Position position, Direction direction, Colony colony) : base(position, direction, colony)
        {
        }

        public override void Move()
        {
            this.Direction = Extensions.GetRandomDirection();
            this.Position = this.Position.GetNeighbour(this.Direction, this.Colony.Width);
        }
    }
}
