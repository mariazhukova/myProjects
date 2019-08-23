using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Pult
    {
        Command Command { get; set; }
        public void SetCommand(Command command)
        {
            this.Command = command;
        }
        public void PressButton()
        {
            Command.Execute();
        }
        public void PressUndo()
        {
            Command.Undo();
        }
        
    }
}
