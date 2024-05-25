namespace StrategyPattern.Sample1
{
    public class QuarterDiscountStategy : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price * 0.75;
        }
    }
}