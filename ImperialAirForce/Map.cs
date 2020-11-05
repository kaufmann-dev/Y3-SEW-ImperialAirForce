using System.Text;
using ImperialAirForce;

namespace ImperialAirForce {
    public class Map {
        private Point[,,] _map = new Point[15, 15, 5];


        public Map() {
            Init();
        }

        private void Init() {
            for (int x = 0; x < _map.GetLength(0); x++) {
                for (int y = 0; y < _map.GetLength(1); y++) {
                    for (int z = 0; z < _map.GetLength(2); z++) {
                        _map[x, y, z] = new DefaultField(x, y, z);
                    }
                }
            }
        }
        
        public string Render() {
            StringBuilder builder = new StringBuilder();

            return null;
        }

        public bool IsPointLegal(Point p) {
            if (p.X < 0 || p.Y < 0
                        || p.X >= _map.GetLength(0)
                        || p.Y >= _map.GetLength(1)
                        || p.Z < 0
                        || p.Z >= _map.GetLength(2))
                return false;
            return true;
        }
    }
}