using System.Collections.Generic;

namespace ImperialAirForce
{
    public class Hellion : Imp {
        private const int POINTCOST = 26;
        
        public Hellion(int speed, int altitude) 
            : base(2, speed, 3, 2, 8, 7, 2, 5, altitude) {
        }
        
        Dictionary<ERange, EWeaponOrientation> _weapons = new Dictionary<ERange, EWeaponOrientation>();
    }
}