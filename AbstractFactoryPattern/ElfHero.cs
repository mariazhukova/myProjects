using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class ElfHero:HeroAbstractFactory
    {
        public ElfHero()
        {

        }

        public override Movement Movement()
        {
            return new Fly();
        }

        public override Wepon Wepon()
        {
            return new Arbalet();
        }
    }
}
