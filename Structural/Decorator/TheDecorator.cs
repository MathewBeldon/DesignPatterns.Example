namespace Decorator
{
    public interface Sanitise
    {
        string Transform(string input);
    }

    public class Sanitiser : Sanitise
    {
        public string Transform(string input)
        {
            return input;
        }
    }

    public abstract class SanitiseDecorator : Sanitise
    {
        protected Sanitise sanitise;

        public void SetSanitiser(Sanitise sanitise)
        {
            this.sanitise = sanitise;
        }

        public virtual string Transform(string input)
        {
            return sanitise.Transform(input);
        }
    }

    public class RemoveCommaDecorator : SanitiseDecorator
    {
        public override string Transform(string input)
        {
            return base.Transform(input).Replace(",", string.Empty);
        }
    }

    public class RemoveQuoteDecorator : SanitiseDecorator
    {
        public override string Transform(string input)
        {
            return base.Transform(input).Replace("\"", string.Empty);
        }
    }

    public class RemoveSpaceDecorator : SanitiseDecorator
    {
        public override string Transform(string input)
        {
            return base.Transform(input).Replace(" ", string.Empty);
        }
    }

    public class RemovePlusDecorator : SanitiseDecorator
    {
        public override string Transform(string input)
        {
            return base.Transform(input).Replace("+", string.Empty);
        }
    }
}
