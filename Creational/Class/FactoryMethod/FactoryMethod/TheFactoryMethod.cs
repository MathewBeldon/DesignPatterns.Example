namespace FactoryMethod
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

    abstract class Creator
    {
        private Product _product;

        public Creator(string toCase)
        {
            _product = CreateProduct(toCase);
        }

        public Product Product { get { return _product; } }
        public abstract Product CreateProduct(string toCase);
    }

    class ConcreteCreator : Creator
    {
        public ConcreteCreator(string toCase) : base(toCase)
        {
        }

        public override Product CreateProduct(string toCase)
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
}
