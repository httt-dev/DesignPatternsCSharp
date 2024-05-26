using System;

namespace StatePattern.Sample1
{
    public class Steak
    {
        private IStateOfSteak _stateOfSteak;
        private int _temperature;

        public Steak()
        {
            _stateOfSteak = new RareSteakState();
            _temperature = 0;
        }

        public void SetState(IStateOfSteak newState)
        {
            _stateOfSteak = newState;
        }

        public void Cook()
        {
            _temperature += 10;
            Console.WriteLine($"Current temperature : {_temperature} degrees");
            _stateOfSteak.Cook(this);
        }

        public int GetTemperature() => _temperature;
    }
}