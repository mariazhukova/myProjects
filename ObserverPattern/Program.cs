using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Lesson lesson = new Lesson(DateTime.Now, "English");
            Student student1 = new Student("Mihael", lesson);
            Manager manager = new Manager("Svetlana", lesson);
            Student student2 = new Student("Olga", lesson);
            SystemAdmin systemAdmin = new SystemAdmin(new List<Observer>() { student1, student2, manager });

            lesson.ChangeLesson(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 3));
            systemAdmin.Update();
            lesson.ChangeLesson(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1));
            systemAdmin.Update();
            Console.ReadLine();

        }
    }
}
