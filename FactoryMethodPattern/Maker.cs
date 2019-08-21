using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    abstract class Maker
    {
        ProductNames productName { get; set; }
        public Maker(ProductNames productName)
        {
            this.productName = productName;
        }

        abstract public MilkProduct MakeProduct();
        
    }

    public enum ProductNames
    {
        Milk,
        СottageСheese,
        Cheese
    }
}
