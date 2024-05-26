using System;

namespace StatePattern.Sample1
{
    public class WellDoneSteakState : IStateOfSteak
    {
        public void Cook(Steak steak)
        {
            Console.WriteLine("The steak is well done.Cooking is complete");
        }
    }
}