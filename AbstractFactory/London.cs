using System.Collections.Generic;

namespace AbstractFactory
{
    public class London : ICapitalCity
    {
        public int GetPopulation()
        {
            return 8900000;
        }

        public List<string> ListTopAttractions()
        {
            return new List<string>{"Tower Bridge" , "Buckingham Palace"};
        }
    }
}