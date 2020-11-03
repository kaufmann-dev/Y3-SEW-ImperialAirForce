using System.Collections.Generic;

namespace ImperialAirForce
{
    public class Executioner : Imp {
        private const int POINTCOST = 23;
        
        public Executioner(int speed, int altitude) 
            : base(3, speed, 2, 2, 7, 6, 3, 5, altitude) {
        }
        
        Dictionary<ERange, EWeaponOrientation> _weapons = new Dictionary<ERange, EWeaponOrientation>();
    }
}