using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{

    public abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int level = default);

        protected void CustomWriteLine(int level, string name, char delimiter)
        {
            Console.WriteLine($"{new string(' ', level)}{delimiter} {name}");
        }
    }

    public class Folder : Component
    {
        List<Component> children = new List<Component>();

        public Folder(string name) : base(name){}

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display(int level = default)
        {
            CustomWriteLine(level, name, '-');

            foreach (Component component in children)
            {
                component.Display(level + 1);
            }
        }
    }

    public class File : Component
    {
        public File(string name) : base(name){}

        public override void Add(Component c)
        {
            throw new InvalidOperationException("Cannot add to a file");
        }

        public override void Remove(Component c)
        {
            throw new InvalidOperationException("Cannot remove from a file");
        }

        public override void Display(int level = default)
        {
            CustomWriteLine(level, name, '*');
        }
    }    
}
