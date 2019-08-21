using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Baker
    {
        public Cake BakeCake(CakeBuilder cakeBuilder)
        {
            cakeBuilder.StartCake();
            cakeBuilder.SetPastry();
            cakeBuilder.SetFilling();
            cakeBuilder.SetAddings();
            cakeBuilder.SetDecoration();
            return cakeBuilder.Cake;

        }
    }
}
