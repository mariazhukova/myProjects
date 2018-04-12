using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    class Student:IComparable
    {
        public string Name;
        public int Age;
        public Student(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int CompareTo(object obj)
        {
            ////if (((Student)obj).Age > Age) return 1;
            ////if (((Student)obj).Age < Age) return -1;
            ////return 0;
            
            return string.Compare(((Student)obj).Name, Name);
        }
    }
    class Program
    {
      //delegate can get the spetial type and return the spetial type
        static int Compare(Student one,Student two)
        {
            return String.Compare(one.Name, two.Name);
        }

        static void Main(string[] args)
        {
            Student[] students =
                { new Student("AAA", 26),
                  new Student("BBB", 18),
                  new Student("CCC", 20) };

        //    Array.Sort(students, Compare);
            Array.Sort(students);


        }
    }
}
