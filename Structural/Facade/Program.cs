namespace Facade
{
    class Program
    {
        static void Main()
        {
            const string input = ",,,,, + test string + \"\"\"\"\"\"";

            TextTransformer transformer = new TextTransformer();

            string t1 = transformer.RemoveSpaceAndComma(input);
            Console.WriteLine($"Removed space and comma: {t1}");

            string t2 = transformer.RemovePlusAndQuote(input);
            Console.WriteLine($"Removed plus and quote: {t2}");

            string t3 = transformer.RemoveAll(input);
            Console.WriteLine($"Removed all: {t3}");

            Console.ReadKey();
        }
    }
}