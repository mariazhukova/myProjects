using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class WeddingCake : CakeBuilder
    {
        public override void SetAddings()
        {
            this.Cake.Addengs = new Addengs() { Name = "taste booster" };
        }

        public override void SetDecoration()
        {
            this.Cake.Decoration = new Decoration() { Name = "Flowers" };
        }

        public override void SetFilling()
        {
            this.Cake.Filling = new Filling() { Name = "Chocolate" };
        }

        public override void SetPastry()
        {
            this.Cake.Pastry = new Pastry() { Name = "Biscuit" };
        }
    }
}
