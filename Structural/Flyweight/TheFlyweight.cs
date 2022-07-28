using System.Text.Json;

namespace Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> flyweights { get; set; } = new Dictionary<string, Flyweight>();

        public FlyweightFactory(params Pixel[] pixels)
        {
            foreach (var pixel in pixels)
            {
                flyweights.Add(pixel.GetHash(), new Flyweight(pixel));
            }
        }

        public Flyweight GetFlyweight(Pixel pixel)
        {
            if (flyweights.ContainsKey(pixel.GetHash()))
            {
                Console.WriteLine("Reusing flyweight");
                return flyweights[pixel.GetHash()];
            } 
            else
            {
                Console.WriteLine("Creating new flyweight");
                var flyweight = new Flyweight(pixel);
                flyweights.Add(pixel.GetHash(), flyweight);
                return flyweight;
            }
        }

        public void DisplayFlyweights()
        {
            Console.WriteLine($"Count: {flyweights.Count}");
            foreach (var flyweight in flyweights)
            {
                Console.WriteLine($"Hash: {flyweight.Key}");
            }
        }
    }

    public class Flyweight
    {
        private Pixel _sharedState;

        public Flyweight(Pixel pixel)
        {
            _sharedState = pixel;
        }

        public void Operation(Pixel uniquePixel)
        {
            string state = JsonSerializer.Serialize(_sharedState);
            string unique = JsonSerializer.Serialize(uniquePixel);
            Console.WriteLine($"shared state {state} unique state {unique}");
        }
    }

    public class Pixel
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public string GetHash()
        {
            return $"{R}-{G}-{B}";
        }
    }
}
