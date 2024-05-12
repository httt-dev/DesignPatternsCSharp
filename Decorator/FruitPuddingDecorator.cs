namespace Decorator
{
    public class FruitPuddingDecorator : MilkTeaDecorator
    {
        public FruitPuddingDecorator(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 3d + base.Cost();
        }
    }
}