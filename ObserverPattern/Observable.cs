using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface Observable
    {
        void AddObserver(Observer observer);
        void NotifyObservers();
        void RemoveObserver(Observer observer);

    }
}
