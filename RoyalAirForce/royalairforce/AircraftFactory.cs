namespace royalairforce
{
    public class AircraftFactory {
        public static Aircraft BigBurna(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 3, 2, 3, 7, 4, 4, 4, 22, EPlayerType.ORK);
            a.Weapons.Add(WeaponFactory.QuadBigShootas());
            a.Weapons.Add(WeaponFactory.TurretBigShootas());
            a.Weapons.Add(WeaponFactory.TailGun());
            GameEngine.AircraftList.Add(a);
            return a;
        }

        public static Aircraft Vulture(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 2, 2, 3, 8, 5, 3, 4, 23, EPlayerType.ORK);
            a.Weapons.Add(WeaponFactory.QuadBigShootas());
            GameEngine.AircraftList.Add(a);
            return a;
        }

        public static Aircraft GrotBommer(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 6, 1, 2, 4, 3, 5, 4, 28, EPlayerType.ORK);
            a.Weapons.Add(WeaponFactory.QuadBigShootas());
            a.Weapons.Add(WeaponFactory.PortTurret());
            a.Weapons.Add(WeaponFactory.StarbordTurret());
            GameEngine.AircraftList.Add(a);
            return a;
        }

        public static Aircraft BlueDevil(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 5, 1, 2, 5, 3, 3, 5, 26, EPlayerType.IMP);
            a.Weapons.Add(WeaponFactory.Lascannon());
            a.Weapons.Add(WeaponFactory.DorsalTurret());
            a.Weapons.Add(WeaponFactory.RearTurret());
            a.Weapons.Add(WeaponFactory.BombBay());
            GameEngine.AircraftList.Add(a);
            return a;
        }

        public static Aircraft Hellion(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 2, 3, 2, 8, 7, 2, 5, 26, EPlayerType.IMP);
            a.Weapons.Add(WeaponFactory.TwinMultiLasers());
            GameEngine.AircraftList.Add(a);
            return a;
        }

        public static Aircraft Executioner(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 3, 2, 2, 7, 6, 3, 5, 23, EPlayerType.IMP);
            a.Weapons.Add(WeaponFactory.QuadAutocannon());
            a.Weapons.Add(WeaponFactory.TwinLascannon());
            GameEngine.AircraftList.Add(a);
            return a;
        }
    }
}