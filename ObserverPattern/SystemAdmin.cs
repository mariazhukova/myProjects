using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class SystemAdmin
    {
        List<Observer> observers;
        int availibleCount = 0;
        public SystemAdmin(List<Observer> observers)
        {
            this.observers = observers;
        }
        public void Update()
        {
            observers.ForEach(o =>
            {
                if (o is Student)
                {
                    var student = o as Student;
                    if (!student.Avalible)
                    {
                        student.lesson.RemoveObserver(student);
                        availibleCount--;
                    }
                    else
                        availibleCount++;
                        
                }
            });

            ShowMessage();
        }

        private void ShowMessage()
        {
            if (availibleCount <= 0)
                Console.WriteLine("No students are available, lesson can be rejected");
            else
                Console.WriteLine($"{availibleCount} students will be on the lesson");
        }
    }
}
