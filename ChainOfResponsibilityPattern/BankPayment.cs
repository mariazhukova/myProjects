using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class BankPayment : PaymentMethod
    {
        public override void Hendle(Reciever reciever)
        {
            if (reciever.BankMetchod)
                Console.WriteLine("Payment via Bank");
            else
                Successor?.Hendle(reciever);
        }
    }
}
