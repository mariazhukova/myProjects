using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class CheeseMaker:Maker
    {
        public CheeseMaker() : base(ProductNames.Cheese)
        {

        }
        public override MilkProduct MakeProduct()
        {
            return new Cheese();
        }
    }
}
