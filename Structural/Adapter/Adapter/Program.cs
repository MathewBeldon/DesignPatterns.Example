namespace Adapter
{
    public class Program
    {
        public static void Main()
        {
            const string textToTransform = "TrAnSForM ThiS TExT To LoWeR";
            IAdapter target = new Adapter();
            var transformedText = target.Request(textToTransform);

            Console.WriteLine(textToTransform);
            Console.WriteLine(transformedText);

            Console.ReadKey();
        }
    }
}