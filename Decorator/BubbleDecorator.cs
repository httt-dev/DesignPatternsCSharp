namespace Decorator
{
    public class BubbleDecorator : MilkTeaDecorator
    {
        public BubbleDecorator(IMilkTea inner) : base(inner)
        {
            
        }

        public override double Cost()
        {
            // price of bubble = 1 $ 
            // gia cuoi cung la gia cua inner + 1d 
            // base chinh la inner
            
            return 1d + base.Cost();
        }
    }
}