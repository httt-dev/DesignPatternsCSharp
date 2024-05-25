using System;
using System.Security.Policy;
using System.Threading;
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
                Ticket ticket = new Ticket();
                ticket.SetName("Ticket : " + (i+1).ToString());
                ticket.SetPrice(500*(i+1));
                
                GeneratePromote(randomTicket, ticket);
                // get discount price
                // var promotePrice = ticket.GetPromotePrice();
                
                Console.WriteLine(ticket.ToString());
                Thread.Sleep(1);
                GeneratePromote(randomTicket, ticket);
                Console.WriteLine(ticket.ToString());
                Console.WriteLine("--------------------------------------");
            }
        }

        private static void GeneratePromote(Random randomTicket, Ticket ticket)
        {
            var discountType = randomTicket.Next(0, 3); // 3 loai 
            switch (discountType)
            {
                case 0:
                    ticket.SetPromoteStrategy(new NoDiscountStrategy());
                    break;
                case 1:
                    ticket.SetPromoteStrategy(new QuarterDiscountStategy());
                    break;
                    
                case 2:
                    ticket.SetPromoteStrategy(new HalfDiscountStategy());
                    break;
            }
        }
    }
}