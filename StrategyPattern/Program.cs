using System;
using System.Security.Policy;
using StrategyPattern.Sample1;

namespace StrategyPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Sample1 
            Random randomTicket = new Random();
            for (var i = 0; i < 5; i++)
            {
                var discountType = randomTicket.Next(0, 2); // 3 loai 
                
                Ticket ticket = new Ticket();
                ticket.SetPrice(500*(i+1));
                
                switch (discountType)
                {
                    case 0:
                        ticket.SetName($"Ticket >> {i+1} 0% discount ");
                        ticket.SetPromoteStrategy(new NoDiscountStrategy());
                        break;
                    case 1:
                        ticket.SetName($"Ticket >> {i+1} 25% discount ");
                        ticket.SetPromoteStrategy(new QuarterDiscountStategy());
                        break;
                    
                    case 2:
                        ticket.SetName($"Ticket >> {i+1} 50% discount ");
                        ticket.SetPromoteStrategy(new HalfDiscountStategy());
                        break;
                }
                
                // get discount price

                // var promotePrice = ticket.GetPromotePrice();
                
                Console.WriteLine(ticket.ToString());

            }
        }
    }
}