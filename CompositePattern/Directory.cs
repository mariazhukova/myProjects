using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Directory: Component
    {
        List<Component> Components = new List<Component>();

        public Directory(string name):base(name)
        {
           }

        public override void Add(Component component)
        {
            Components.Add(component);
        }

        public override void Remove(Component component)
        {
            Components.Remove(component);
        }

        public override void Display()
        {
            Console.WriteLine($"Directory {Name}");
            Components.ForEach(e => e.Display());
        }


    }
}
