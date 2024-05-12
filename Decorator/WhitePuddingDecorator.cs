namespace Decorator
{
    public class WhitePuddingDecorator : MilkTeaDecorator
    {
        public WhitePuddingDecorator(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 1.5d + base.Cost();
        }
    }
}