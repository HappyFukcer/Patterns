using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace Patterns.Strategy
{
    class Blade : IWeapon
    {
        public int Damage { get; private set; }

        public Blade(int damage)
        {
            Damage = damage;
        }

        public float Attack(int def)
        {
            return (Damage * def / 100);
        }
    }
}
