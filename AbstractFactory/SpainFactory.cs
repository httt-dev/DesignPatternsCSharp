namespace AbstractFactory
{
    public class SpainFactory : IInternationalFactory
    {
        public ILanguage CreateLanguage()
        {
            return new Spanish();
        }

        public ICapitalCity CreateCapital()
        {
            return new Madrid();
        }
    }
}