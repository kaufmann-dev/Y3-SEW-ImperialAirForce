namespace ImperialAirForce
{
    public class MovementCost {
        private readonly int _speedCost;
        private readonly int _maneuverCost;
        private readonly int _stepCount;

        public int SpeedCost => _speedCost;

        public int ManeuverCost => _maneuverCost;

        public int StepCount => _stepCount;

        public MovementCost(int speedCost, int maneuverCost, int stepCount) {
            _speedCost = speedCost;
            _maneuverCost = maneuverCost;
            _stepCount = stepCount;
        }
    }
}