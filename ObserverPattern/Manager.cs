using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Manager:Observer
    {
        string Name;
        Observable observable;
        public Manager(string name, Observable lesson)
        {
            Name = name;
            this.observable = lesson;
            this.observable.AddObserver(this);
        }
        public void Update(Observable observable)
        {
            Lesson lesson = (Lesson)observable;
            DateTime date = lesson.DateTime;
            DateTime maxDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 2);
            if (date < maxDay)
                IssueWarning();
            else
                Console.WriteLine(String.Format("Manager {0} sent a message: {1}",Name, "Shift is ok"));

        }

        private void IssueWarning()
        {
            Console.WriteLine(String.Format("Manager {0} sent a warning: {1}",Name,"Shift is possible at least on 3 days"));
        }
    }
}
