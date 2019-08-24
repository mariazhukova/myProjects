

namespace ChainOfResponsibilityPattern
{
    class Reciever
    {
        public bool BankMetchod { get; private set; }
        public bool CashMethod { get; private set; }
        public bool PayPalMethod { get; private set; }

        public Reciever(bool isBank,bool isCash,bool isPayPal)
        {
            BankMetchod = isBank;
            CashMethod = isCash;
            PayPalMethod = isPayPal;
        }
    }
}
