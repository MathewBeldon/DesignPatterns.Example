namespace Builder
{
    class Program
    {
        static void Main()
        {
            ProductMaker productMaker = new ProductMaker("Text to transform LOWER upper");

            var toLowerAndCommaBuilder = new ToLowerAndCommaBuilder();
            var lowerCommaProduct = productMaker.Make(toLowerAndCommaBuilder);
            lowerCommaProduct.ShowTransforms();

            Console.WriteLine();

            var toUpperAndSemicolonBuilder = new ToUpperAndSemicolonBuilder();
            var upperSemicolonProduct = productMaker.Make(toUpperAndSemicolonBuilder);
            upperSemicolonProduct.ShowTransforms();

            Console.ReadKey();
        }
    }   
}