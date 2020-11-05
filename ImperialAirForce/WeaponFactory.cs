using System.Collections.Generic;

namespace ImperialAirForce
{
    public class WeaponFactory {
        public static Weapon CreateQuadBigShootas() {
            Dictionary<ERange, int> distances = new Dictionary<ERange, int>();
            distances[ERange.SMALL] = 8;
            distances[ERange.MEDIUM] = 4;
            distances[ERange.LARGE] = 0;

            Weapon bigshoota = new Weapon(5, distances,
                new List<EWeaponOrientation>() {EWeaponOrientation.FRONT});

            return bigshoota;
        }
    }
}