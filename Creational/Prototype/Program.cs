namespace Prototype
{
    class Program
    {
        static void Main()
        {
            PixelColour pixelColourOne = new PixelColour(233, 32, 42, 255);
            PixelColour pixelColourTwo = pixelColourOne.GetClone(); //traditional clone
            PixelColour pixelColourThree = pixelColourOne with { }; //new record clone
            pixelColourTwo.Green = 222;
            pixelColourThree.Blue = 111;

            Console.WriteLine(pixelColourOne.ToString());
            Console.WriteLine(pixelColourTwo.ToString());
            Console.WriteLine(pixelColourThree.ToString());

            Console.ReadKey();
        }
    }
}