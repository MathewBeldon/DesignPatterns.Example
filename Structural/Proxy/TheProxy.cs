namespace Proxy
{
    public interface ITransform
    {
        string RemoveSpace(string input);
        string RemoveComma(string input);
        string ToUpper(string input);
        string ToLower(string input);
    }

    public class Transform : ITransform
    {
        public string RemoveSpace(string input)
        {
            return input.Replace(" ", string.Empty);
        }

        public string RemoveComma(string input)
        {
            return input.Replace(",", string.Empty);
        }

        public string ToUpper(string input)
        {
            return input.ToUpper();
        }

        public string ToLower(string input)
        {
            return input.ToLower();
        }
    }

    public class TransformProxy : ITransform
    {
        private Transform _transform = new Transform();
        public string RemoveSpace(string input)
        {
            return _transform.RemoveSpace(input);
        }

        public string RemoveComma(string input)
        {
            return _transform.RemoveComma(input);
        }

        public string ToUpper(string input)
        {
            return _transform.ToUpper(input);
        }

        public string ToLower(string input)
        {
            return _transform.ToLower(input);
        }
    }
}
