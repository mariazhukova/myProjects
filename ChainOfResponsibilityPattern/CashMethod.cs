using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
   class CashMethod : PaymentMethod
    {
        public override void Hendle(Reciever reciever)
        {
            if (reciever.CashMethod)
                Console.WriteLine("Payment via Cash");
            else
                Successor?.Hendle(reciever);
        }
    }
}
