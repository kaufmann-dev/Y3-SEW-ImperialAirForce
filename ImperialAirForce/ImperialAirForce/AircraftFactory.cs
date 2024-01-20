namespace ImperialAirForce
{
    public class AircraftFactory {
        public static Aircraft CreateBigBurna(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 3, 2, 3, 7, 4, 4, 4, 22, EPlayerType.ORK);
            a.Weapons.Add(WeaponFactory.CreateQuadBigShootas());
            a.Weapons.Add(WeaponFactory.CreateTurretBigShootas());
            a.Weapons.Add(WeaponFactory.CreateTailGun());
            GameEngine.AircraftList.Add(a);
            return a;
        }

        public static Aircraft CreateVulture(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 2, 2, 3, 8, 5, 3, 4, 23, EPlayerType.ORK);
            a.Weapons.Add(WeaponFactory.CreateQuadBigShootas());
            GameEngine.AircraftList.Add(a);
            return a;
        }

        public static Aircraft CreateGrotBommer(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 6, 1, 2, 4, 3, 5, 4, 28, EPlayerType.ORK);
            a.Weapons.Add(WeaponFactory.CreateQuadBigShootas());
            a.Weapons.Add(WeaponFactory.CreatePortTurret());
            a.Weapons.Add(WeaponFactory.CreateStarbordTurret());
            GameEngine.AircraftList.Add(a);
            return a;
        }

        public static Aircraft CreateBlueDevil(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 5, 1, 2, 5, 3, 3, 5, 26, EPlayerType.IMP);
            a.Weapons.Add(WeaponFactory.CreateLascannon());
            a.Weapons.Add(WeaponFactory.CreateDorsalTurret());
            a.Weapons.Add(WeaponFactory.CreateRearTurret());
            a.Weapons.Add(WeaponFactory.CreateBombBay());
            GameEngine.AircraftList.Add(a);
            return a;
        }

        public static Aircraft CreateHellion(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 2, 3, 2, 8, 7, 2, 5, 26, EPlayerType.IMP);
            a.Weapons.Add(WeaponFactory.CreateTwinMultiLasers());
            GameEngine.AircraftList.Add(a);
            return a;
        }

        public static Aircraft CreateExecutioner(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 3, 2, 2, 7, 6, 3, 5, 23, EPlayerType.IMP);
            a.Weapons.Add(WeaponFactory.CreateQuadAutocannon());
            a.Weapons.Add(WeaponFactory.CreateTwinLascannon());
            GameEngine.AircraftList.Add(a);
            return a;
        }
    }
}