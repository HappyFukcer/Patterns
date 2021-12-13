using Patterns.Abstract_Factory.Products.Abstract;

namespace Patterns.Abstract_Factory.Factories.Abstract
{
    public abstract class AbstractFactory
    {
        public abstract HealPotions GetHealingPotion();
        public abstract IncreasePotions GetIncreasePotion();
    }
}
