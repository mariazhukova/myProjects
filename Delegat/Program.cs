using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    class Student : IComparable
    {
        public string Name;
        public int Age;
        public Student(string name, int age)
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

    //class CompareStudents
    //{
    //    //delegate can get the spetial type and return the spetial type
    //    delegate int Compare(Student one, Student two);
    //    Student[] students =
    //           { new Student("AAA", 26),
    //              new Student("BBB", 18),
    //              new Student("CCC", 20) };
    //    Compare com = new Compare(Com);
    //    //Array.Sort(students, com);
    //    Array.Sort(students);
    //        TimerDelegate tim = new TimerDelegate();
    //    tim.Timer();
    //        GrnericDelegate genericDelegate = new GrnericDelegate();
    //    genericDelegate.CreateGenericDelegate();

        
    //    static int Com(Student one, Student two)
    //    {
    //        return String.Compare(one.Name, two.Name);
    //    }
    //}

    class Program
    {

        static void Main(string[] args)
        {
            Book book = new Book("1");
            book.Add("2");
            book.Add("3");
            
        }


    }
}
