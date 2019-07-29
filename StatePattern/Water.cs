using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class Water
    {
        public IWaterState State { get; set; }
        public Water(IWaterState state)
        {
            State = state;
        }
        public void Frost()
        {
            State.Frost(this);
        }

        public void Heat()
        {
            State.Heat(this);
        }
    }
}
