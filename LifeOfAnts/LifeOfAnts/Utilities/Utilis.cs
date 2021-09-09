﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeOfAnts.Utilities
{
    public static class Utilis
    {
        public static (int amountDrones, int amountSoldiers, int amountWorkers) SetNumberOfAnts(int colonyWidth)
        {
            int colonySize = colonyWidth * colonyWidth;
            float percentageOfSettlement = 0.45f;
            int amountOfAnts = (int)(colonySize * percentageOfSettlement);

            int drones = (int)(amountOfAnts * 0.05f);
            int soldiers = (int)(amountOfAnts * 0.35f);
            int workers = (int)(amountOfAnts * 0.6f);

            if (drones <= 0)
            {
                drones = 1;
            }

            return (drones, soldiers, workers);
        }
    }
}
