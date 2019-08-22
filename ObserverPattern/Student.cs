using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Student : Observer
    {
        string Name;
        public Observable lesson { get; private set; }
        public bool Avalible { get; private set; } =true;
        public Student(string name, Observable lesson)
        {
            Name = name;
            this.lesson = lesson;
            this.lesson.AddObserver(this);
        }
        public void Update(Observable observable)
        {
            Lesson lesson = (Lesson)observable;
            DateTime date = lesson.DateTime;
            DateTime maxDay = new DateTime(DateTime.Now.Year,DateTime.Now.Month, DateTime.Now.Day + 2) ;
            if (date < maxDay)
                CancelParticipation();
            else
            {
                Avalible = true;
                Console.WriteLine(Name + " will go");
            }
                

        }

        private void CancelParticipation()
        {
            Avalible = false;
            Console.WriteLine(Name+" have plans already");
        }
    }
}
