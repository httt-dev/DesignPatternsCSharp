namespace AbstractFactory
{
    // ConcreteFactory1
    public class EnglandFactory : IInternationalFactory
    {
        public ILanguage CreateLanguage()
        {
            return new English();
        }

        public ICapitalCity CreateCapital()
        {
            return new London();
        }
    }
}