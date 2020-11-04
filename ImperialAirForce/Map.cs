using System.Text;
using ImperialAirForce;

namespace aernauticaimperialis {
    public class Map : GameEngine
    {
        public Map[,,] _map;

        public Map[,,] Map1
        {
            get => _map;
            set => _map = value;
        }

        public GameEngine _gameEngine;

        public GameEngine GameEngine
        {
            get => _gameEngine;
            set => _gameEngine = value;
        }

        public Map(int x, int y, int z)
        {
            _map = new Map[x, y, z];
        }
        
        public void Init(GameEngine aGameEngine) {
            for (int i = 0; i < _map.GetLength(0); i++) {
                for (int j = 0; j < _map.GetLength(1); j++) {
                    for (int k = 0; k < _map.GetLength(2); k++)
                    {
                        
                    }
                }
            }
        }

        public string Render() {
            StringBuilder builder = new StringBuilder();
            int count = 0;

            for (int i = 0; i < _map.GetLength(0); i++)
            {
                for (int j = 0; j < _map.GetLength(1); j++)
                {
                    for (int k = 0; k < _map.GetLength(2); k++)
                    {
                        builder.Append(_map[i, j, k]);
                    }

                    builder.Append('\n');
                }

                builder.Append('\n');
            }

            return builder.ToString();
        }
        
        public bool IsPointLegal(Point p) 
        {
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