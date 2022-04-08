namespace Singleton
{
    class Program
    {
        static void Main()
        {
            var singleton = TheSingleton.Instance;

            //call singleton, will also initialise
            singleton.DoStuff();

            //call singleton, already initialised
            singleton.DoStuff();

            Console.ReadKey();
        }
    }
}