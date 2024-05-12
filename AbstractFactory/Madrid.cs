using System.Collections.Generic;

namespace AbstractFactory
{
    public class Madrid : ICapitalCity
    {
        public int GetPopulation()
        {
            return 3200000;
        }

        public List<string> ListTopAttractions()
        {
            return new List<string> {"Royal Palace","Prado Museum"};
        }
    }
}