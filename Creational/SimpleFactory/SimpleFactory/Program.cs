namespace SimpleFactory
{
    class Program
    {
        static void Main()
        {
            var productForUpper = SimpleFactory.GetProduct("upper");
            var productForLower = SimpleFactory.GetProduct("lower");
            var productForComma = SimpleFactory.GetProduct("comma");
            var productForSemicolon = SimpleFactory.GetProduct("semicolon");

            Console.WriteLine(productForLower.DoStuff("TO LOWER"));
            Console.WriteLine(productForUpper.DoStuff("to upper"));
            Console.WriteLine(productForComma.DoStuff("I want commas"));
            Console.WriteLine(productForSemicolon.DoStuff("I want semicolons"));

            Console.ReadKey();
        }
    }
}