namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TransformProxy proxy = new TransformProxy();

            const string input = "This Is A String, This Is A String";

            Console.WriteLine($"Removed space: {proxy.RemoveSpace(input)}");
            Console.WriteLine($"Removed comma: {proxy.RemoveComma(input)}");
            Console.WriteLine($"To lowercase: {proxy.ToLower(input)}");
            Console.WriteLine($"To uppercase: {proxy.ToUpper(input)}");

            Console.ReadKey();
        }
    }
}