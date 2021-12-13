using Patterns.Abstract_Factory.Products.Abstract;

namespace Patterns.Abstract_Factory.Products.Conctere.Stats
{
    public class StatsHeal : HealPotions
    {
        public override string Effect => $"{base.Effect} Stat!";
    }
}
