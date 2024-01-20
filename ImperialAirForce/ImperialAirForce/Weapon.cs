using System.Collections.Generic;

namespace ImperialAirForce
{
    public class Weapon {
        private int _damage;

        private readonly Dictionary<ERange, int> _distances = null;
        private readonly List<EWeaponOrientation> _orientations = null;

        public int Damage {
            get => _damage;
            set => _damage = value;
        }

        public Dictionary<ERange, int> Distances {
            get => _distances;
        }

        public List<EWeaponOrientation> Orientations {
            get => _orientations;
        }

        public Weapon(int damage, Dictionary<ERange, int> distances, List<EWeaponOrientation> orientations) {
            _damage = damage;
            _distances = distances;
            _orientations = orientations;
        }
    }
}