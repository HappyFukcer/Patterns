using Patterns.Abstract_Factory.Products.Abstract;

namespace Patterns.Abstract_Factory.Products.Conctere.Stats
{
    public class StatsIncrease : IncreasePotions
    {
        public override string Effect => $"{base.Effect} Stats!";
    }
}
