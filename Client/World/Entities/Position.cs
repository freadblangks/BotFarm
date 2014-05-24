﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.World.Entities
{
    public class Position
    {
        public const int INVALID_MAP_ID = -1;

        public float X
        {
            get;
            set;
        }

        public float Y
        {
            get;
            set;
        }
        public float Z
        {
            get;
            set;
        }
        public float O
        {
            get;
            set;
        }
        public int MapID
        {
            get;
            set;
        }

        public Position(float x, float y, float z, float o, int mapID)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.O = o;
            this.MapID = mapID;
        }

        public Position() : this(0.0f, 0.0f, 0.0f, 0.0f, INVALID_MAP_ID)
        { }

        public Position GetPosition()
        {
            return new Position(X, Y, Z, O, MapID);
        }
    }
}
