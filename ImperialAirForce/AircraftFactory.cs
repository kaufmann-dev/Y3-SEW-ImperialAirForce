namespace ImperialAirForce
{
    public class AircraftFactory {
        public static Aircraft CreateBigBurna(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 3, 2, 3, 7, 4, 4,4, 22);
            a.Weapons.Add(WeaponFactory.CreateQuadBigShootas());
            return a;
        }

        public static Aircraft Vulture(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 2, 2, 3, 8, 5, 3, 4, 23);
            a.Weapons.Add(WeaponFactory.CreateQuadBigShootas());
            return a;
        }
        
        
    }
}