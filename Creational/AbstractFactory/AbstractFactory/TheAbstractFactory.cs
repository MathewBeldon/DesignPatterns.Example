namespace AbstractFactory
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

    abstract class SuperFactory
    {
        public abstract Product GetProduct(string productType);

        public static SuperFactory CreateConcreateFactory(string concreteType)
        {
            switch (concreteType.ToLower())
            {
                case "case":
                    return new ConcreateCreatorCaseFactory();
                case "replace":
                    return new ConcreateCreatorReplaceFactory();
            }

            throw new NotSupportedException();
        }
    }

    class ConcreateCreatorCaseFactory : SuperFactory
    {
        public override Product GetProduct(string toCase)
        {
            switch (toCase.ToLower())
            {
                case "lower":
                    return new ConcreteProductToLowerCase();
                case "upper":
                    return new ConcreteProductToUpperCase();
            }

            throw new NotSupportedException();
        }
    }

    class ConcreateCreatorReplaceFactory : SuperFactory
    {
        public override Product GetProduct(string toReplace)
        {
            switch (toReplace.ToLower())
            {
                case "comma":
                    return new ConcreteProductSpaceToComma();
                case "semicolon":
                    return new ConcreteProductSpaceToSemicolon();
            }

            throw new NotSupportedException();
        }
    }
}
