namespace ImperialAirForce
{
    public class Imp : Unit
    {
        public Imp(int structure, int speed,  int handling, int maxThrottle, int minSpeed, int maxSpeed, int maxManeuver, int maxAltitude, int altitude) : base(structure, speed, maxThrottle, minSpeed, maxSpeed, maxManeuver, handling, maxAltitude, altitude) {}
    }
}