using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    class MangerMediator : Mediator
    {
        public Colleague  customer { get; set; }
        public Colleague programmer { get; set; }
        public Colleague tester { get; set; }
        public override void Send(string message, Colleague colleague)
        {
           if (customer == colleague)
            {
                programmer.Notify(message);
            }
           else if(programmer==colleague)
            {
                tester.Notify(message);
            }
           else if (tester==colleague)
            {
                customer.Notify(message);
            }
        }
    }
}
