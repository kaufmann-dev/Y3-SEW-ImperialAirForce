using System;
using System.Collections.Generic;

namespace ImperialAirForce
{
    public class Point {
        private int _x;
        private int _y;
        private int _z;
        protected EFieldType _fieldType;
        
        public int X {
            get => _x;
            set => _x = value;
        }
        public int Y {
            get => _y;
            set => _y = value;
        }
        public int Z {
            get => _z;
            set => _z = value;
        }
        
        public Point(int x, int y, int z) {
            _x = x;
            _y = y;
            _z = z;
        }

        public override bool Equals(object obj)
        {
            Point p = (Point) obj;
            
            if (p.X == X && p.Y == Y && p.Z == Z)
            {
                return true;
            }

            return false;
        }
        
        public List<Point> CalculateRoute(Point destination) {
            List<Point> route = new List<Point>();

            int diffX = Math.Abs(_x - destination._x);
            int diffY = Math.Abs(_y - destination._y);
            int diffZ = Math.Min(Math.Max(diffX, diffY), Math.Abs(_z - destination._z));

            int stepX = (_x == destination.X) ? 0 : (_x < destination.X) ? 1 : -1;
            int stepY = (_y == destination.Y) ? 0 : (_y < destination.Y) ? 1 : -1;
            int stepZ = (_z == destination.Z) ? 0 : (_z < destination.Z) ? 1 : -1;

            for (int i = 1, j = 1, k = 1, step = 0; step < Math.Max(diffX, diffY); step++) {
                route.Add(new Point(_x + (i * stepX), j + (_y * stepY), _z + (k * stepZ)));

                if (i < diffX) i++;
                if (j < diffY) j++;
                if (k < diffZ) k++;
            }
            return route;
        }
    }
}