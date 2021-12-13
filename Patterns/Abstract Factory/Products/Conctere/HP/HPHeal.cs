using Patterns.Abstract_Factory.Products.Abstract;

namespace Patterns.Abstract_Factory.Products.Conctere.HP
{
    public class HPHeal : HealPotions
    {
        public override string Effect => $"{base.Effect} HP!";
    }
}
