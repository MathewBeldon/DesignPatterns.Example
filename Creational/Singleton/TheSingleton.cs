namespace Singleton
{
    public sealed class TheSingleton
    {
        private static readonly Lazy<TheSingleton> _lazySingleton = 
            new Lazy<TheSingleton>(() => new TheSingleton());

        private TheSingleton()
        {
            Console.WriteLine("CREATED A SINGLETON");
        }

        public static TheSingleton Instance
        {
            get { return _lazySingleton.Value; }
        }

        public void DoStuff()
        {
            Console.WriteLine("I AM THE SINGLETON");
        }
    }
}
