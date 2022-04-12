namespace Prototype
{
    abstract record ThePrototype
    {
        public abstract ThePrototype GetClone();
    }

    record PixelColour : ThePrototype
    {
        public int Red;
        public int Green;
        public int Blue;
        public int Alpha;

        public PixelColour(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public override PixelColour GetClone()
        {
            return MemberwiseClone() as PixelColour ?? throw new NullReferenceException(nameof(PixelColour));
        }
    }
}