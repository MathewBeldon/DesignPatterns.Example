namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            var productForLower = new ConcreteCreator("lower").Product;
            var productForUpper = new ConcreteCreator("upper").Product;

            Console.WriteLine(productForLower.DoStuff("TO LOWER"));
            Console.WriteLine(productForUpper.DoStuff("to upper"));

            Console.ReadKey();
        }
    }
}