using System;

namespace AbstractFactory
{
    public class InternationalProvider
    {
        public static IInternationalFactory  Create(Country country)
        {
            switch (country)
            {
                case Country.ENGLAND:
                    return new EnglandFactory();
                    break;
                
                case Country.SPAIN:
                    return new SpainFactory();
                    break;
                default:
                    throw new NotSupportedException($"{country} is not currently supported.");
            }
        }
    }
}