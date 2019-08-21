using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class MilkProduct
    {
        public delegate void ProductionHendler();
        public event ProductionHendler ShowResult;
        protected void ResultIs()
        {
            if (this.ShowResult != null)
                ShowResult.Invoke();
                
        }
    }
}
