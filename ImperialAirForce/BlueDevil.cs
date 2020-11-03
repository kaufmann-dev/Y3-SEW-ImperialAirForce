using System.Collections.Generic;

namespace ImperialAirForce
{
    public class BlueDevil : Imp {
        private const int POINTCOST = 26;
        
        public BlueDevil(int speed, int altitude) 
            : base(5, speed, 1, 2, 5, 3, 3, 5, altitude) {
        }
        
        Dictionary<ERange, EWeaponOrientation> _weapons = new Dictionary<ERange, EWeaponOrientation>();
    }
}