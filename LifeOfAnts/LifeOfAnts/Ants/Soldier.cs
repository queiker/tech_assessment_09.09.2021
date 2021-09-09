﻿using System;
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
    public class Soldier : Ant
    {
        private bool _isInitDirectionSet;

        public Soldier(Position position, Direction direction, Colony colony) : base(position, direction, colony)
        {
        }

        public override void Move()
        {
            if (_isInitDirectionSet == false)
            {
                SetInitBorderSoldierDirection();
                _isInitDirectionSet = true;
            }

            Position = Position.GetNeighbour(Direction, Colony.Width);
            SetSoldierDirection();
        }

        private void SetInitBorderSoldierDirection()
        {
            Random random = new Random();
            int randomDirection = random.Next(0, 2);
            List<Direction> direction = new List<Direction>();

            if (Position.Equals(Position.Zero))
            {
                Direction = Direction.East;
            }
            else if (Position.X == 0 && Position.Y == Colony.Width - 1)
            {
                Direction = Direction.South;
            }
            else if (Position.X == Colony.Width - 1 && Position.Y == 0)
            {
                Direction = Direction.North;
            }
            else if (Position.X == Colony.Width - 1 && Position.Y == Colony.Width - 1)
            {
                Direction = Direction.West;
            }
            else if (Position.X == 0 && Position.Y > 0 && Position.Y < Colony.Width - 1)
            {
                direction.Add(Direction.South);
                direction.Add(Direction.East);
                Direction = direction[randomDirection];
            }
            else if (Position.Y == Colony.Width - 1 && Position.X > 0 && Position.X < Colony.Width - 1)
            {
                direction.Add(Direction.West);
                direction.Add(Direction.South);
                Direction = direction[randomDirection];
            }
            else if (Position.X == Colony.Width - 1 && Position.Y > 0 && Position.Y < Colony.Width - 1)
            {
                direction.Add(Direction.North);
                direction.Add(Direction.West);
                Direction = direction[randomDirection];
            }
            else if (Position.Y == 0 && Position.X > 0 && Position.X < Colony.Width - 1)
            {
                direction.Add(Direction.East);
                direction.Add(Direction.North);
                Direction = direction[randomDirection];
            }
        }

        private void SetSoldierDirection()
        {
            if (Direction == Direction.North)
            {
                Direction = Direction.East;
            }
            else if (Direction == Direction.East)
            {
                Direction = Direction.South;
            }
            else if (Direction == Direction.South)
            {
                Direction = Direction.West;
            }
            else if (Direction == Direction.West)
            {
                Direction = Direction.North;
            }
        }
    }
}
