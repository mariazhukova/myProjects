using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    class Tester : Colleague
    {
        public Tester(Mediator mediator) : base(mediator) { }
        public override void Notify(string msg)
        {
            Console.WriteLine("message to tester: {0}", msg);
        }
    }
}
