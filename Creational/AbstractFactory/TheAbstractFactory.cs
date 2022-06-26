namespace AbstractFactory
{
    abstract class CaseProduct
    {
        public abstract string ChangeCase(string input);
    }

    abstract class ReplaceProduct
    {
        public abstract string ReplaceCharacter(string input);
    }

    class ConcreteProductToLowerCase : CaseProduct
    {
        public override string ChangeCase(string input)
        {
            return input.ToLower();
        }
    }

    class ConcreteProductToUpperCase : CaseProduct
    {
        public override string ChangeCase(string input)
        {
            return input.ToUpper();
        }
    }

    class ConcreteProductSpaceToComma : ReplaceProduct
    {
        public override string ReplaceCharacter(string input)
        {
            return input.Replace(" ", ",");
        }
    }

    class ConcreteProductSpaceToSemicolon : ReplaceProduct
    {
        public override string ReplaceCharacter(string input)
        {
            return input.Replace(" ", ";");
        }
    }

    abstract class SuperFactory
    {
        public abstract CaseProduct CreateCaseProduct();

        public abstract ReplaceProduct CreateReplaceProduct();

    }

    class LowerCaseCommaFactory : SuperFactory
    {
        public override CaseProduct CreateCaseProduct()
        {
            return new ConcreteProductToLowerCase();
        }

        public override ReplaceProduct CreateReplaceProduct()
        {
            return new ConcreteProductSpaceToComma();
        }
    }

    class UpperCaseSemicolonFactory : SuperFactory
    {
        public override CaseProduct CreateCaseProduct()
        {
            return new ConcreteProductToUpperCase();
        }

        public override ReplaceProduct CreateReplaceProduct()
        {
            return new ConcreteProductSpaceToSemicolon();
        }
    }

    class Client
    {
        private readonly CaseProduct _caseProduct;
        private readonly ReplaceProduct _replaceProduct;

        public Client(SuperFactory factory)
        {
            _caseProduct = factory.CreateCaseProduct();
            _replaceProduct = factory.CreateReplaceProduct();
        }

        public string ChangeCase(string input)
        {
            return _caseProduct.ChangeCase(input);
        }

        public string ReplaceCharacter(string input)
        {
            return _replaceProduct.ReplaceCharacter(input);
        }
    }
}
