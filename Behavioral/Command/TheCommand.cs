namespace Command
{
    public abstract class Command
    {
        public abstract string Execute();
        public abstract string UnExecute();
    }

    public class TransformCommand : Command
    {
        Action _action;
        string _input;
        Transformer _transformer;

        public TransformCommand(Transformer transformer,
            Action action, string input)
        {
            _transformer = transformer;
            _action = action;
            _input = input;
        }

        public Action Action
        {
            set { _action = value; }
        }

        public string Input
        {
            set { _input = value; }
        }

        public override string Execute()
        {
            return _transformer.Operation(_action, _input);
            
        }

        public override string UnExecute()
        {
            return _input;
        }
    }

    public class Transformer
    {
        string _input;
        public string Operation(Action action, string input)
        {
            switch (action)
            {
                case Action.RemoveSpace: _input = input.Replace(" ", string.Empty); break;
                case Action.RemoveComma: _input = input.Replace(",", string.Empty); break;
                case Action.ToLower: _input = input.ToLower(); break;
                case Action.ToUpper: _input = input.ToUpper(); break;
                default: _input = input; break;
            }

            return _input;
        }
    }

    public class User
    {
        Transformer transformer = new Transformer();
        List<Command> commands = new List<Command>();
        int current = 0;
        string _input;
        public User(string input)
        {
            _input = input;
            Console.WriteLine("Original: {0}\n", _input);
        }

        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (current <= commands.Count - 1)
                {
                    Command command = commands[current++];
                    _input = command.Execute();
                    Console.WriteLine("Redo result: {0}", _input);
                }
            }
            Console.WriteLine("Redone {0} actions", levels);
        }

        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    Command command = commands[--current];
                    _input = command.UnExecute();
                    Console.WriteLine("Undo result: {0}", _input);
                }
            }
            Console.WriteLine("Undone {0} actions\n", levels);
        }

        public void Compute(Action action)
        {
            Command command = new TransformCommand(transformer, action, _input);
            Console.WriteLine("Performing action: {0} on string `{1}`", action, _input);
            _input = command.Execute();
            Console.WriteLine("Result: `{0}`\n", _input);

            commands.Add(command);
            current++;
        }
    }

    public enum Action
    {
        RemoveSpace,
        RemoveComma,
        ToLower,
        ToUpper
    }
}
