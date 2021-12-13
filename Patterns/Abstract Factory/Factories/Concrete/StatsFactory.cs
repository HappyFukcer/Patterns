using Patterns.Abstract_Factory.Factories.Abstract;
using Patterns.Abstract_Factory.Products.Abstract;
using Patterns.Abstract_Factory.Products.Conctere.Stats;

namespace Patterns.Abstract_Factory.Factories.Concrete
{
    public class StatsFactory : AbstractFactory
    {
        public override HealPotions GetHealingPotion()
        {
            return new StatsHeal();
        }

        public override IncreasePotions GetIncreasePotion()
        {
            return new StatsIncrease();
        }
    }
}
