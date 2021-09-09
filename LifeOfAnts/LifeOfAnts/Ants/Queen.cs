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
    public class Queen : Ant
    {
        public int MatingMood { get; protected internal set; }
        public Queen(Position position, Direction direction, Colony colony) : base(position, direction, colony)
        {
            int maxMatingMood = 101;
            MatingMood = maxMatingMood.SetQueenMatingMood();
        }

        public override void Move()
        {
        }

        public void UpdateQueenMatingMood()
        {
            if (MatingMood > 0)
            {
                MatingMood--;
            }
        }
    }
}
