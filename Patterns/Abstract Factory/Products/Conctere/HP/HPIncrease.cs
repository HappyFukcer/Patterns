using Patterns.Abstract_Factory.Products.Abstract;
namespace Patterns.Abstract_Factory.Products.Conctere.HP
{
    public class HPIncrease : IncreasePotions
    {
        public override string Effect => $"{base.Effect} MP!";
    }
}
