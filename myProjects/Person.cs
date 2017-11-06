using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProjects
{
    public class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

    }
}
