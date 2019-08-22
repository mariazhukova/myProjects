using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Car
    {
        public MovableStratagy movable { private get; set; }
        int places { get; set; }
        string model { get; set; }
        public Car(string model, int places, MovableStratagy movable)
        {
            this.movable = movable;
        }

        public void Move() {
            movable.Move();
        }
    }
}
