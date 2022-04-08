namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            var factoryForCase = SuperFactory.CreateConcreateFactory("case");
            var productForUpper = factoryForCase.GetProduct("upper");
            var productForLower = factoryForCase.GetProduct("lower");

            Console.WriteLine(productForLower.DoStuff("TO LOWER"));
            Console.WriteLine(productForUpper.DoStuff("to upper"));


            var factoryForReplace = SuperFactory.CreateConcreateFactory("replace");
            var productForComma = factoryForReplace.GetProduct("comma");
            var productForSemicolon = factoryForReplace.GetProduct("semicolon");

            Console.WriteLine(productForComma.DoStuff("I want commas"));
            Console.WriteLine(productForSemicolon.DoStuff("I want semicolons"));

            Console.ReadKey();
        }
    }
}