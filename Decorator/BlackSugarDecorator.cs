namespace Decorator
{
    public class BlackSugarDecorator : MilkTeaDecorator
    {
        public BlackSugarDecorator(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 2d + base.Cost();
        }
    }
}