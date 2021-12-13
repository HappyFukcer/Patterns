using Patterns.Abstract_Factory.Factories.Abstract;
using Patterns.Abstract_Factory.Products.Abstract;
using Patterns.Abstract_Factory.Products.Conctere.MP;
using System;

namespace Patterns.Abstract_Factory.Factories.Concrete
{
    public class MPFactory : AbstractFactory
    {
        public override HealPotions GetHealingPotion()
        {
            return new MPHeal();
        }

        public override IncreasePotions GetIncreasePotion()
        {
            return new MPIncrease();
        }
    }
}
