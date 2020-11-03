using System.Collections.Generic;

namespace ImperialAirForce
{
    public class BigBurna : Ork {
        private const int POINTCOST = 22;
        
        public BigBurna(int speed, int altitude) 
            : base(3, speed, 2, 3, 7, 4, 4, 4, altitude) {
        }
        
        Dictionary<ERange, EWeaponOrientation> _weapons = new Dictionary<ERange, EWeaponOrientation>();
    }
}