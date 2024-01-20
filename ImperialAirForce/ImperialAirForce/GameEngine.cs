using System.Collections.Generic;

namespace ImperialAirForce
{
    public class GameEngine {
        private static GameEngine _instance = new GameEngine();
        private static readonly List<Aircraft> _aircraftList = new List<Aircraft>();
        
        public static List<Aircraft> AircraftList {
            get => _aircraftList;
        }

        private GameEngine() {
            
        }

        public static GameEngine GetInstance() {
            return _instance;
        }
        
        
    }
}