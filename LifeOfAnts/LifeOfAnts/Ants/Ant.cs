using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeOfAnts.Utilities;
using LifeOfAnts;


namespace LifeOfAnts.Ants
{
    public abstract class Ant
    {
        public Position position { get; protected set; }
        public Direction direction { get; protected set; }
        public Colony colony { get; }

        public Ant()
        {

        }

    }
}
