namespace Flyweight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var flyweightFactory = new FlyweightFactory(
                new Pixel { R = 22, G = 12, B = 33 },
                new Pixel { R = 112, G = 1, B = 99 },
                new Pixel { R = 42, G = 255, B = 123 },
                new Pixel { R = 55, G = 0, B = 0 }
            );

            AddPixel(new Pixel { R = 22, G = 12, B = 33, PositionX = 1, PositionY = 3 });
            AddPixel(new Pixel { R = 22, G = 12, B = 33, PositionX = 1, PositionY = 4 });
            AddPixel(new Pixel { R = 112, G = 1, B = 99, PositionX = 444, PositionY = 555 });
            AddPixel(new Pixel { R = 55, G = 0, B = 0, PositionX = 222, PositionY = 23 });
            AddPixel(new Pixel { R = 42, G = 255, B = 123, PositionX = 1233, PositionY = 3321 });
            AddPixel(new Pixel { R = 255, G = 255, B = 255, PositionX = 999, PositionY = 999 });

            flyweightFactory.DisplayFlyweights();

            Console.ReadKey();

            void AddPixel(Pixel pixel)
            {
                var flyweight = flyweightFactory.GetFlyweight(new Pixel
                {
                    R = pixel.R,
                    G = pixel.G,
                    B = pixel.B
                });

                flyweight.Operation(pixel);
                Console.WriteLine();
            }
        }
    }
}