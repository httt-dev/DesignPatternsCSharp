using System;

namespace StrategyPattern.Sample1
{
    public class Ticket
    {
        private IPromoteStrategy _promoteStrategy;
        private double _price;
        private string _name;

        public IPromoteStrategy GetPromoteStrategy()
        {
            return _promoteStrategy;
        }

        public void SetPromoteStrategy(IPromoteStrategy value)
        {
            _promoteStrategy = value;
        }
        
        public double GetPrice() => _price;

        public void SetPrice(double value) => _price = value;
        
        public string GetName() => _name;

        public void SetName(string value) => _name = value;

        public double GetPromotePrice()
        {
            return _promoteStrategy.DoDiscount(_price);
        }

        public Ticket()
        {
            
        }
        public Ticket(IPromoteStrategy promoteStrategy)
        {
            _promoteStrategy = promoteStrategy;
        }

        public override string ToString()
        {
            return $"{_promoteStrategy.GetType()} : Ticket {_name} with {_price} ,after discount price >> {GetPromotePrice()}";
        }
    }
}