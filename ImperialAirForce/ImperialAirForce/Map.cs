using System;
using System.Text;
using ImperialAirForce;

namespace ImperialAirForce {
        public class Map {
        private readonly Point[,,] _map = new Point[15, 15, 5];
        
        private const int Width = 15, Height = 15, Altitude = 5;

        public Map() {
            //Init();
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

        public void Render() {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= Height; i++) {
                for (int j = 1; j <= Altitude; j++) {
                    for (int k = 1; k <= Width; k++) {
                        bool written = false;
                        foreach (Aircraft aircraft in GameEngine.AircraftList) {
                            if (aircraft.Equals(new Point(k, i, j))) {
                                if (aircraft.PlayerType == EPlayerType.ORK) {
                                    sb.Append("o ");
                                }
                                else if(aircraft.PlayerType == EPlayerType.IMP) {
                                    sb.Append("i ");
                                }

                                written = true;
                            }
                            
                        }
                        if (!written) {
                            sb.Append("_ ");
                        }
                    }

                    sb.Append("  ");
                }
                
                sb.AppendLine();
            }
            
            Console.WriteLine(sb.ToString());
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