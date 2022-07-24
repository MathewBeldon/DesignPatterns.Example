namespace Facade
{
    public class RemoveSpace
    {
        public string Transform(string input)
        {
            return input.Replace(" ", string.Empty);
        }
    }

    public class RemoveComma
    {
        public string Transform(string input)
        {
            return input.Replace(",", string.Empty);
        }
    }

    public class RemovePlus
    {
        public string Transform(string input)
        {
            return input.Replace("+", string.Empty);
        }
    }

    public class RemoveQuote
    {
        public string Transform(string input)
        {
            return input.Replace("\"", string.Empty);
        }
    }

    public class TextTransformer
    {
        RemoveSpace removeSpace;
        RemoveComma removeComma;
        RemovePlus removePlus;
        RemoveQuote removeQuote;

        public TextTransformer()
        {
            removeSpace = new RemoveSpace();
            removeComma = new RemoveComma();
            removePlus = new RemovePlus();
            removeQuote = new RemoveQuote();
        }

        public string RemoveSpaceAndComma(string input)
        {
            string spaceRemoved = removeSpace.Transform(input);
            return removeComma.Transform(spaceRemoved);
        }

        public string RemovePlusAndQuote(string input)
        {
            string plusRemoved = removePlus.Transform(input);
            return removeQuote.Transform(plusRemoved);
        }

        public string RemoveAll(string input)
        {
            string spaceRemoved = removeSpace.Transform(input);
            string commaRemoved = removeComma.Transform(spaceRemoved);
            string plusRemoved = removePlus.Transform(commaRemoved);
            return removeQuote.Transform(plusRemoved);
        }
    }
}
