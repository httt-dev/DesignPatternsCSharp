namespace Decorator
{
    public class EggPuddingDecorator : MilkTeaDecorator
    {
        public EggPuddingDecorator(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 3d + base.Cost();
        }
    }
}