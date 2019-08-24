using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    abstract class PaymentMethod
    {
        public PaymentMethod Successor { get; set; }
        public abstract void Hendle(Reciever reciever);
    }
}
