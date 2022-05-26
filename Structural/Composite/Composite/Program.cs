namespace Composite
{
    public class Program
    {
        public static void Main()
        {
            Folder root = new Folder("root");
            root.Add(new File("index.html"));
            root.Add(new File("style.css"));

            Folder src = new Folder("src");
            src.Add(new File("program.cs"));
            src.Add(new File("startup.cs"));
            root.Add(src);

            Folder controller = new Folder("controllers");
            controller.Add(new File("home_controller.cs"));
            File accountController = new File("account_controller.cs");
            controller.Add(accountController);

            src.Add(controller);            
            root.Display();

            Console.WriteLine("\nDELETE `account_controllers.cs` from `controllers` \n");

            controller.Remove(accountController);
            root.Display();

            Console.WriteLine("\nDELETE `controllers` \n");

            src.Remove(controller);
            root.Display();

            Console.ReadKey();
        }
    }
}