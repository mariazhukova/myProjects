using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class PayPalMethod : PaymentMethod
    {
        public override void Hendle(Reciever reciever)
        {
            if (reciever.PayPalMethod)
                Console.WriteLine("Payment via PayPal");
            else
                Successor?.Hendle(reciever);
        }
    }
}
