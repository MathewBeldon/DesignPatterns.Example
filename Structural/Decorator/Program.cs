namespace Decorator
{
    class Program
    {
        static void Main()
        {
            const string input = ",,,,, + test string + \"\"\"\"\"\"";

            Sanitise sanitise = new Sanitiser();
            SanitiseDecorator removeCommaDecorator = new RemoveCommaDecorator();
            SanitiseDecorator removeQuoteDecorator = new RemoveQuoteDecorator();
            SanitiseDecorator removeSpaceDecorator = new RemoveSpaceDecorator();
            SanitiseDecorator removePlusDecorator = new RemovePlusDecorator();

            string s1 = sanitise.Transform(input);
            Console.WriteLine($"Default string: {s1}");

            removeCommaDecorator.SetSanitiser(sanitise);
            string t1  = removeCommaDecorator.Transform(input);
            Console.WriteLine($"Removed commas: {t1}");

            removeQuoteDecorator.SetSanitiser(sanitise);
            string t2 = removeQuoteDecorator.Transform(input);
            Console.WriteLine($"Removed quotes: {t2}");

            removeSpaceDecorator.SetSanitiser(sanitise);
            string t3 = removeSpaceDecorator.Transform(input);
            Console.WriteLine($"Removed space: {t3}");

            removePlusDecorator.SetSanitiser(sanitise);
            string t4 = removePlusDecorator.Transform(input);
            Console.WriteLine($"Removed plus: {t4}");

            //long chain 
            removeCommaDecorator.SetSanitiser(sanitise);
            removeQuoteDecorator.SetSanitiser(removeCommaDecorator);
            removeSpaceDecorator.SetSanitiser(removeQuoteDecorator);
            removePlusDecorator.SetSanitiser(removeSpaceDecorator);
            string t5 = removePlusDecorator.Transform(input);
            Console.WriteLine($"Removed all: {t5}");

            Console.ReadKey();
        }
    }
}