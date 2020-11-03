namespace ImperialAirForce
{
    public class Unit
    {
        protected int _structure;
        protected int _speed;
        protected int _minSpeed;
        protected int _maxSpeed;
        protected int _handling;
        protected int _altitude;
        protected int _maxAltitude;
        protected int _maxThrottle;
        protected int _maxManeuver;


        public Unit(int structure, int speed, int maxThrottle, int minSpeed, int maxSpeed, int maxManeuver, int handling, int maxAltitude, int altitude) {
            _handling = handling;
            _structure = structure;
            _speed = speed;
            _minSpeed = minSpeed;
            _maxSpeed = maxSpeed;
            _maxThrottle = maxThrottle;
            _maxManeuver = maxManeuver;
            _maxAltitude = maxAltitude;
            _altitude = altitude;
        }
    }
}