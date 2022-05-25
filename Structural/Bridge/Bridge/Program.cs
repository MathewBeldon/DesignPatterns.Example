namespace Bridge
{
    public class Program
    {
        const string TEXT_TO_TRANSFORM = "This Text To Transform";

        public static void Main()
        {
            Abstraction transformer = new RefinedAbstraction();

            transformer.Implementor = new ToLowerImplementor();
            Console.WriteLine("    To Lower: " + transformer.Transform(TEXT_TO_TRANSFORM));

            transformer.Implementor = new ToUpperImplementor();
            Console.WriteLine("    To Upper: " + transformer.Transform(TEXT_TO_TRANSFORM));

            transformer.Implementor = new RemoveSpaceImplementor();
            Console.WriteLine("Remove Space: " + transformer.Transform(TEXT_TO_TRANSFORM));

            Console.ReadKey();
        }
    }
}
