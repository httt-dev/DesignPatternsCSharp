using System;
using StatePattern.Sample1;
using StatePattern.Sample2;
using StatePattern.Sample3;

namespace StatePattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Sample 1

            Steak steak = new Steak();

            while (steak.GetTemperature() < 165)
            {
                steak.Cook();
            }
            
            // Sample2

            var car = new Car();
            
            Console.WriteLine($"State : {car.CurrentState}");
            car.TakeAction(Car.Action.Start);
            Console.WriteLine($"State : {car.CurrentState}");
            car.TakeAction(Car.Action.Start);
            Console.WriteLine($"State : {car.CurrentState}");
            car.TakeAction(Car.Action.Accelerate);
            Console.WriteLine($"State : {car.CurrentState}");
            car.TakeAction(Car.Action.Stop);
            Console.WriteLine($"State : {car.CurrentState}");
            
            // Sample 3
            TransactionContext transactionContext = new TransactionContext(new InputCardState());
            
            transactionContext.Request(); // InputCard -> InputPin
            transactionContext.Request(); // InputPin -> CashDraw
            transactionContext.Request(); // CashDraw -> Complete
            transactionContext.Request(); // Complete
            
        }
    }
}