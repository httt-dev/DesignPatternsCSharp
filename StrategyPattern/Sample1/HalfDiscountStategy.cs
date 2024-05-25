namespace StrategyPattern.Sample1
{
    public class HalfDiscountStategy : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price * 0.5;
        }
    }
}