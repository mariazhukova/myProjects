using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class FrutCake : CakeBuilder
    {
        public override void SetAddings()
        {
            this.Cake.Addengs = new Addengs() { Name = "taste booster" };
        }

        public override void SetDecoration()
        {
           
        }

        public override void SetFilling()
        {
            this.Cake.Filling = new Filling() { Name = "Fruts" };
        }

        public override void SetPastry()
        {
            this.Cake.Pastry = new Pastry() { Name = "Biscuit" };
        }
    }
}
