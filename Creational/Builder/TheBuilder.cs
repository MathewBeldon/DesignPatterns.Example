namespace Builder
{
    public class Product
    {
        public string OriginalText { get; set; }
        public string? CaseChangedText { get; set; }
        public string? ReplaceText { get; set; }

        public Product(string originalText)
        {
            OriginalText = originalText ?? throw new ArgumentNullException(nameof(originalText));
        }

        public void ShowTransforms()
        {
            Console.WriteLine("Orignal Text: " + OriginalText);
            Console.WriteLine("Case Changed Text: " + CaseChangedText);
            Console.WriteLine("Replaced Text: " + ReplaceText);
        }
    }

    public abstract class TheBuilder
    {
        protected Product _product;

        public abstract void CaseChangeText();
        public abstract void ReplaceText();

        public void CreateProduct(string originalText)
        {
            _product = new Product(originalText);
        }
        public Product GetProduct()
        {
            return _product;
        }
    }

    class ToLowerAndCommaBuilder : TheBuilder
    {
        public override void CaseChangeText()
        {
            _product.CaseChangedText = _product.OriginalText.ToLower();
        }

        public override void ReplaceText()
        {
            _product.ReplaceText = _product.OriginalText.Replace(" ", ",");
        }
    }

    class ToUpperAndSemicolonBuilder : TheBuilder
    {
        public override void CaseChangeText()
        {
            _product.CaseChangedText = _product.OriginalText.ToUpper();
        }

        public override void ReplaceText()
        {
            _product.ReplaceText = _product.OriginalText.Replace(" ", ";");
        }
    }

    public class ProductMaker
    {
        private string _originalText;
        public ProductMaker(string originalText)
        {
            _originalText = originalText;
        }

        public Product Make(TheBuilder theBuilder)
        {
            theBuilder.CreateProduct(_originalText);
            theBuilder.CaseChangeText();
            theBuilder.ReplaceText();

            return theBuilder.GetProduct();
        }
    }
}
