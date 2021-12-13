using Patterns.Abstract_Factory.Products.Abstract;

namespace Patterns.Abstract_Factory.Products.Conctere.MP
{
    public class MPHeal : HealPotions
    {
        public override string Effect => $"{base.Effect} MP!";
    }
}
