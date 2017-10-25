using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student_List list = new Student_List();
            List<string> ListOfStudents = new List<string>();
            int id = 1;

            Console.Write("Please enter the name and age of student. If you finich press 'End'");
            Console.WriteLine();
            while (Console.ReadKey().Key != ConsoleKey.End)
            { 
                string line_st = Console.ReadLine();
                Console.WriteLine();
                ListOfStudents.Add(id+" "+line_st);
                id++;
            }

            Console.WriteLine();
            Console.WriteLine("It is your list:");
            foreach (var st in ListOfStudents)
                Console.WriteLine(st);

            Console.WriteLine();
            Console.WriteLine("If you want to remove press 'R', to add press 'A'");

            while (Console.ReadKey().Key != ConsoleKey.End)
            {
                string line_st = Console.ReadLine();
                if (line_st == "a")
                {
                    ListOfStudents.Add(id + " " + line_st);
                    id++;
                }

                else if (line_st == "r")
                {
                    Console.WriteLine("enter the number");
                    string number = Console.ReadLine();
                    ListOfStudents.RemoveAt(Int32.Parse(number) - 1);
              
                   
                }
            }

            Console.WriteLine();
            Console.WriteLine("It is your list:");
            foreach (var st in ListOfStudents)
                Console.WriteLine(st);
        }
    }
    

   public class Student_List
    {     
        public List<object> CreateListofStudents()
        {

            var firstStudent = CreateList("Григорий Васичкин", 21, "Student");
            var secondStudent = CreateList("Василий Пупкин", 23, "Student");
            var thirdStudent = CreateList("Гальна Огнева", 19, "Student");
            List<object> finishList = new List<object>();
            finishList.Add(firstStudent);
            finishList.Add(secondStudent);
            finishList.Add(thirdStudent);
            return finishList;

        }

        private List<List<object>> CreateList(object name,object age, object role)
        {
            List<List<object>> students = new List<List<object>>();
            List<object> student = new List<object>();

            student.Add(name);
            student.Add(age);
            student.Add(role);
            students.Add(student);

            return students;
        }

        public void Show(List<object> List)
        {
          
                foreach(var st in List)
                {
                    Console.WriteLine(st);
                }
            

        }
        
    }
}
