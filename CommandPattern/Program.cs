using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tV = new TV();
            TVOnOffCommand tVCommand = new TVOnOffCommand(tV);
            TVVolumeComand tVVolumeComand = new TVVolumeComand(tV);
            Pult pult = new Pult();
            pult.SetCommand(tVCommand);
            pult.PressButton();
            pult.SetCommand(tVVolumeComand);
            pult.PressButton();
            pult.PressButton();
            pult.PressButton();
            pult.PressButton();
            pult.PressUndo();
            pult.SetCommand(tVCommand);
            pult.PressUndo();

            Console.ReadKey();
        }
    }
}
