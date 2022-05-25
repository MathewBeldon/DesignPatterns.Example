namespace Bridge
{
    internal class Abstraction
    {
        protected IImplementor implementor;
        public IImplementor Implementor
        {
            set { implementor = value; }
        }
        public virtual string Transform(string text)
        {
            return implementor.Transform(text);
        }
    }

    internal interface IImplementor
    {
        string Transform(string text);
    }

    internal sealed class RefinedAbstraction : Abstraction
    {
        public override string Transform(string text)
        {
            return implementor.Transform(text);
        }
    }

    internal sealed class ToLowerImplementor : IImplementor
    {
        public string Transform(string text)
        {
            return text.ToLower();
        }
    }

    internal sealed class ToUpperImplementor : IImplementor
    {
        public string Transform(string text)
        {
            return text.ToUpper();
        }
    }

    internal sealed class RemoveSpaceImplementor : IImplementor
    {
        public string Transform(string text)
        {
            return text.Replace(" ", string.Empty);
        }
    }
}
