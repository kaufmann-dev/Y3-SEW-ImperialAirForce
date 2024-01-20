using System.Collections.Generic;

namespace royalairforce
{
    public class WeaponFactory {
        public static Weapon QuadBigShootas() {
            Dictionary<ERange, int> distances = new Dictionary<ERange, int>();
            distances[ERange.SMALL] = 8;
            distances[ERange.MEDIUM] = 4;
            distances[ERange.LARGE] = 0;

            Weapon bigshoota = new Weapon(5, distances,
                new List<EWeaponOrientation>() {EWeaponOrientation.FRONT});

            return bigshoota;
        }

        public static Weapon TurretBigShootas()
        {
            Dictionary<ERange, int> distances = new Dictionary<ERange, int>();
            distances[ERange.SMALL] = 3;
            distances[ERange.MEDIUM] = 1;
            distances[ERange.LARGE] = 0;
            
            Weapon turretbigshoota = 
                new Weapon(5, distances, 
                    new List<EWeaponOrientation>(){EWeaponOrientation.REAR, EWeaponOrientation.RIGHT, EWeaponOrientation.LEFT, EWeaponOrientation.UP});

            return turretbigshoota;
        }

        public static Weapon TailGun()
        {
            Dictionary<ERange, int> distances = new Dictionary<ERange, int>();
            distances[ERange.SMALL] = 1;
            distances[ERange.MEDIUM] = 0;
            distances[ERange.LARGE] = 0;
            
            Weapon tailgun = new Weapon(6, distances,
                new List<EWeaponOrientation>() {EWeaponOrientation.REAR});

            return tailgun;
        }

        public static Weapon PortTurret()
        {
            Dictionary<ERange, int> distances = new Dictionary<ERange, int>();
            distances[ERange.SMALL] = 2;
            distances[ERange.MEDIUM] = 1;
            distances[ERange.LARGE] = 0;
            
            Weapon weapon = new Weapon(5, distances, new List<EWeaponOrientation>() {EWeaponOrientation.LEFT, EWeaponOrientation.UP});

            return weapon;
        }

        public static Weapon StarbordTurret()
        {
            Dictionary<ERange, int> distances = new Dictionary<ERange, int>();
            distances[ERange.SMALL] = 2;
            distances[ERange.MEDIUM] = 1;
            distances[ERange.LARGE] = 0;
            
            Weapon weapon = new Weapon(5, distances, new List<EWeaponOrientation>() {EWeaponOrientation.RIGHT, EWeaponOrientation.UP});

            return weapon;
        }

        public static Weapon Lascannon()
        {
            Dictionary<ERange, int> distances = new Dictionary<ERange, int>();
            distances[ERange.SMALL] = 0;
            distances[ERange.MEDIUM] = 2;
            distances[ERange.LARGE] = 1;
            
            Weapon weapon = new Weapon(2, distances,
                new List<EWeaponOrientation>() {EWeaponOrientation.FRONT});

            return weapon;
        }

        public static Weapon DorsalTurret()
        {
            Dictionary<ERange, int> distances = new Dictionary<ERange, int>();
            distances[ERange.SMALL] = 3;
            distances[ERange.MEDIUM] = 2;
            distances[ERange.LARGE] = 0;
            
            Weapon weapon = new Weapon(5, distances,
                new List<EWeaponOrientation>() {EWeaponOrientation.ALLROUND, EWeaponOrientation.UP});

            return weapon;
        }

        public static Weapon RearTurret()
        {
            Dictionary<ERange, int> distances = new Dictionary<ERange, int>();
            distances[ERange.SMALL] = 3;
            distances[ERange.MEDIUM] = 2;
            distances[ERange.LARGE] = 0;
            
            Weapon weapon = new Weapon(5, distances,
                new List<EWeaponOrientation>() {EWeaponOrientation.REAR});

            return weapon;
        }

        public static Weapon BombBay()
        {
            Dictionary<ERange, int> distances = new Dictionary<ERange, int>();
            distances[ERange.SMALL] = 8;
            distances[ERange.MEDIUM] = 0;
            distances[ERange.LARGE] = 0;
            
            Weapon weapon = new Weapon(2, distances,
                new List<EWeaponOrientation>() {EWeaponOrientation.REAR});

            return weapon;
        }

        public static Weapon TwinMultiLasers()
        {
            Dictionary<ERange, int> distances = new Dictionary<ERange, int>();
            distances[ERange.SMALL] = 4;
            distances[ERange.MEDIUM] = 6;
            distances[ERange.LARGE] = 2;
            
            Weapon weapon = new Weapon(5, distances,
                new List<EWeaponOrientation>() {EWeaponOrientation.FRONT});

            return weapon;
        }

        public static Weapon QuadAutocannon()
        {
            Dictionary<ERange, int> distances = new Dictionary<ERange, int>();
            distances[ERange.SMALL] = 2;
            distances[ERange.MEDIUM] = 6;
            distances[ERange.LARGE] = 0;
            
            Weapon weapon = new Weapon(4, distances,
                new List<EWeaponOrientation>() {EWeaponOrientation.FRONT});

            return weapon;
        }

        public static Weapon TwinLascannon()
        {
            Dictionary<ERange, int> distances = new Dictionary<ERange, int>();
            distances[ERange.SMALL] = 0;
            distances[ERange.MEDIUM] = 2;
            distances[ERange.LARGE] = 1;
            
            Weapon weapon = new Weapon(2, distances,
                new List<EWeaponOrientation>() {EWeaponOrientation.FRONT});

            return weapon;
        }
    }
}