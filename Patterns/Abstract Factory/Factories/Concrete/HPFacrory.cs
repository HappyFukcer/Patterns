using Patterns.Abstract_Factory.Factories.Abstract;
using Patterns.Abstract_Factory.Products.Abstract;
using Patterns.Abstract_Factory.Products.Conctere.HP;
using System;

namespace Patterns.Abstract_Factory.Factories.Concrete
{
    public class HPFacrory : AbstractFactory
    {
        public override HealPotions GetHealingPotion()
        {
            return new HPHeal();
        }

        public override IncreasePotions GetIncreasePotion()
        {
            return new HPIncrease();
        }
    }
}
