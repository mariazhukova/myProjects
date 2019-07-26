using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    class Programmer : Colleague
    {
        public Programmer(Mediator mediator):base(mediator)
        {

        }
        public override void Notify(string msg)
        {
            Console.WriteLine("Message to programmer: {0}", msg);
        }
    }
}
