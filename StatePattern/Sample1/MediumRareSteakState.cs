using System;

namespace StatePattern.Sample1
{
    public class MediumRareSteakState : IStateOfSteak
    {
        public void Cook(Steak steak)
        {
            if (steak.GetTemperature() <= 140)
            {
                Console.WriteLine("Cooking the steak medium-rare");
            }
            else
            {
                Console.WriteLine("Cooking the steak medium");
                steak.SetState(new MediumSteakState());
            }
        }
    }
}