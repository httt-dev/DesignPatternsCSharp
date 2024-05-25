namespace StrategyPattern.Sample1
{
    public class NoDiscountStrategy : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price;
        }
    }
}