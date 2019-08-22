using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Lesson : Observable
    {
        List<Observer> observers;
        public DateTime DateTime { get; private set; }
        string LessonName;

        public Lesson(DateTime dateTime, string lessonName)
        {
            observers = new List<Observer>();
            DateTime = dateTime;
            LessonName = lessonName;
        }
        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            observers.ForEach(o => o.Update(this));
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void ChangeLesson(DateTime dateTime)
        {
            DateTime = dateTime;
            NotifyObservers();
        }
    }
}
