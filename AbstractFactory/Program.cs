using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IInternationalFactory factory = new EnglandFactory();
            // ILanguage language = factory.CreateLanguage();
            // ICapitalCity capitalCity = factory.CreateCapital();
            //
            // language.Greet();
            // Console.WriteLine($"Total population: {capitalCity.GetPopulation()}");
            // Console.WriteLine($"Top attractions: {string.Join("," , capitalCity.ListTopAttractions())}");
            
            Country country = Country.SPAIN;
            IInternationalFactory factory = InternationalProvider.Create(country);
            ILanguage language = factory.CreateLanguage();
            ICapitalCity capital = factory.CreateCapital();
            
            Console.WriteLine(country);
            Console.WriteLine(capital.GetType().Name);
            language.Greet();
            Console.WriteLine("Total Population: " + capital.GetPopulation());
            Console.WriteLine("Top Attractions: " + string.Join(", ", capital.ListTopAttractions()));
            
        }
    }
}
