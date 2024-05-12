namespace StateDesign.Repository
{
    public sealed class SingletonRepository
    {
        private static IRepository _instance;

        private SingletonRepository()
        {
            
        }

        public static IRepository GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MovieRepository();
                }

                return _instance;
            }
        }
    }
}