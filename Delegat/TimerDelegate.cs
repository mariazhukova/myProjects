using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Timers;

namespace Delegat
{
   public class TimerDelegate
    {
        Timer timer = new Timer(1000);
        ElapsedEventHandler delegat = new ElapsedEventHandler(Timer_Elapset);
        
        public void Timer()
        {
            timer.Elapsed += delegat;
            timer.Start();
            Console.ReadKey();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void Timer_Elapset(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(e.SignalTime);
        }
    }
}
