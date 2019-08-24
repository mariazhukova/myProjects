using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Reciever worker = new Reciever(true, false, true);

            BankPayment bank = new BankPayment();
            PayPalMethod payPal = new PayPalMethod();
            CashMethod cash = new CashMethod();

            bank.Successor = payPal;
            payPal.Successor = cash;
           // cash.Successor = bank;

            cash.Hendle(worker);

            Console.ReadKey();
        }
    }
}
