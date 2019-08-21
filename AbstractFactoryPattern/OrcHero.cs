using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class OrcHero:HeroAbstractFactory
    {
        public OrcHero()
        {

        }
        public override Movement Movement()
        {
            return new Run();
        }

        public override Wepon Wepon()
        {
            return new Hatchet();
        }
    }
}
