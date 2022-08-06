namespace Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create user and let her compute
            User user = new User("This Is A String, This Is A String");

            // User presses calculator buttons
            user.Compute(Action.ToLower);
            user.Compute(Action.ToUpper);
            user.Compute(Action.RemoveComma);
            user.Compute(Action.RemoveSpace);

            user.Undo(4);

            user.Redo(3);

            Console.ReadKey();
        }
    }
}