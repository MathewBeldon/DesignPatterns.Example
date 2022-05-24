namespace Adapter
{
    internal interface IAdapter
    {
        string Request(string text);
    }

    internal sealed class Adapter : IAdapter
    {
        private Adaptee adaptee = new Adaptee();
        public string Request(string text)
        {
            return adaptee.TransformText(text);
        }
    }

    internal sealed class Adaptee
    {
        public string TransformText(string text)
        {
            return text.ToLower();
        }
    }
}
