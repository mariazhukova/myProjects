using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    abstract class Mediator
    {
        public abstract void Send(string message,Colleague colleague);
    }
}
