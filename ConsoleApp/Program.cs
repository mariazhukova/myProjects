using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ListStudents students = new ListStudents()             ;
           

            string myApp = "ConsolApp";
            if (!EventLog.SourceExists(myApp))
                EventLog.CreateEventSource(myApp, "Application");
            EventLog.WriteEntry(myApp,"Application was started");

          }
    }
    

   public class Student_List
    {     
        public void ConsolWork()
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
                ListOfStudents.Add(id + " " + line_st);
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




        private List<List<string>> CreateListofStudents()
        {
            List<List<string>> List = new List<List<string>> ();
            List.Add(new List<string> { "Григорий Васичкин", "21", "Student" });
            List.Add(new List<string> { "Василий Пупкин", "23", "Student" });
            List.Add(new List<string> { "Гальна Огнева", "19", "Student" });
            return List;

        }

        public void Show()
        {
            List<List<string>> ListOfStudents = CreateListofStudents();

            foreach (List<string> subList in ListOfStudents)
            {
                foreach (string item in subList)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
    }

    public class ListStudents:List<Student>
    {
        Student student = new Student();
        
       public ListStudents(string name, int age, string role)
        {
            student.ID= GetNextId(student.ID);
            student.Name = name;
            student.Age = age;
            student.Role = role;
        }

        protected int GetNextId(int id)
        {
            return ++id;
        }
    }

}
