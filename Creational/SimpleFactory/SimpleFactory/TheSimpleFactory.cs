namespace SimpleFactory
{
    abstract class Product
    {
        public abstract string DoStuff(string stuff);
    }

    class ConcreteProductToLowerCase : Product
    {
        public override string DoStuff(string stuff)
        {
            return stuff.ToLower();
        }
    }

    class ConcreteProductToUpperCase : Product
    {
        public override string DoStuff(string stuff)
        {
            return stuff.ToUpper();
        }
    }

    class ConcreteProductSpaceToComma : Product
    {
        public override string DoStuff(string stuff)
        {
            return stuff.Replace(" ", ",");
        }
    }

    class ConcreteProductSpaceToSemicolon : Product
    {
        public override string DoStuff(string stuff)
        {
            return stuff.Replace(" ", ";");
        }
    }

    abstract class SimpleFactory
    {
        public static Product GetProduct(string productType)
        {
            switch (productType.ToLower())
            {
                case "lower":
                    return new ConcreteProductToLowerCase();
                case "upper":
                    return new ConcreteProductToUpperCase();
                case "comma":
                    return new ConcreteProductSpaceToComma();
                case "semicolon":
                    return new ConcreteProductSpaceToSemicolon();
            }

            throw new NotSupportedException();
        }
    }
}
