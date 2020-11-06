namespace ImperialAirForce
{
    public class MovementCost {
        private readonly int _maneuverCost;
        private readonly int _speedCost;
        private readonly int _fieldCount;

        public int ManeuverCost => _maneuverCost;

        public int SpeedCost => _speedCost;

        public int FieldCount => _fieldCount;

        public MovementCost(int maneuverCost, int speedCost, int fieldCount) {
            _maneuverCost = maneuverCost;
            _speedCost = speedCost;
            _fieldCount = fieldCount;
        }
    }
}