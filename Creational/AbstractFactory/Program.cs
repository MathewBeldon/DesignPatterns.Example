namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            SuperFactory lowerCaseCommaFactory = new LowerCaseCommaFactory();
            Client client = new Client(lowerCaseCommaFactory);
            
            Console.WriteLine(client.ChangeCase("TO LOWER"));
            Console.WriteLine(client.ReplaceCharacter("Replace With Comma"));


            SuperFactory upperCaseSemicolonFactory = new UpperCaseSemicolonFactory();
            client = new Client(upperCaseSemicolonFactory);

            Console.WriteLine(client.ChangeCase("to upper"));
            Console.WriteLine(client.ReplaceCharacter("Replace With Semicolon"));

            Console.ReadKey();
        }
    }
}