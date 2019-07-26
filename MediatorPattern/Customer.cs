using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    class Customer : Colleague
    {
        public Customer(Mediator mediator):base(mediator) { }
        public override void Notify(string msg)
        {
            Console.WriteLine("message to customer: {0}", msg);
        }
    }
}
