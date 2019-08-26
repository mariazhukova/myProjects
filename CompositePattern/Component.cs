using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    abstract class Component
    {
        protected string Name { get; private set; }
        
        public Component(string name)
        {
            Name = name;
        }

        public virtual void Add(Component component) { }
        
        public virtual void Remove(Component component) { }

        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
        
    }
}
