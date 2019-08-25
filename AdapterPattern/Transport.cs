using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface Transport
    {
        string Name { get; set; }
        void Move();
    }
}
