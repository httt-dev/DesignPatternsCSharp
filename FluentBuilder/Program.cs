using System;

namespace FluentBuilder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var order = OrderBuilder.Empty()
                .WithNumber(123)
                .WithCreatedOn(DateTime.UtcNow)
                .WithShippingAddress(p => p.Street("NCM")
                    .City("HCM")
                    )
                .Build();
            
            Console.WriteLine(order);
        }
    }
}