using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class CakeBuilder
    {
        public Cake Cake { get; private set; }
        public void StartCake()
        {
            Cake = new Cake();
        }

        public abstract void SetFilling();
        public abstract void SetPastry();
        public abstract void SetDecoration();
        public abstract void SetAddings();

    }
}
