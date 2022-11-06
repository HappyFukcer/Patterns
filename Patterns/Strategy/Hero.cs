using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Strategy
{
    class Hero
    {
        public int Health { get; set; }
        private IWeapon Weapon;
        private float WeaponSkill = 1.1f;

        public Hero(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public float Attack(int def)
        {
            return Weapon.Attack(def) * WeaponSkill;
        }
    }
}
