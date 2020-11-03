using System.Collections.Generic;

namespace ImperialAirForce
{
    public class GrotBommer : Ork {
        private const int POINTCOST = 28;
        
        public GrotBommer(int speed, int altitude) 
            : base(6, speed, 1, 2, 4, 3, 5, 4, altitude) {
        }
        
        Dictionary<ERange, EWeaponOrientation> _weapons = new Dictionary<ERange, EWeaponOrientation>();
    }
}