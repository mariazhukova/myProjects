using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    public class ExampleAccount
    {
        int sum;
        public delegate void Action(string message);
        public event Action Withdrawn;
        public event Action Added;

        public ExampleAccount(int sum)
        {
            this.sum = sum;
        }

        public void Put(int amount)
        {
            this.sum += amount;
            Added?.Invoke(string.Format("Added {0}", amount));
        }

        public void Withdraw(int amount)
        {
            if (sum < amount) Withdrawn?.Invoke(string.Format("Account sum less than {0}", amount));
            else { sum -= amount; Withdrawn?.Invoke(string.Format("Amount {0} withdrawn ", amount)); }
        }

    }
}
