using Patterns.Abstract_Factory.Products.Abstract;

namespace Patterns.Abstract_Factory.Products.Conctere.MP
{
    public class MPIncrease : IncreasePotions
    {
        public override string Effect => $"{base.Effect} MP!";

    }
}
