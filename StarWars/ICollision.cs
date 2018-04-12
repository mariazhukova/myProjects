using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    interface ICollision
    {
        bool Collision(ICollision obj);
        Rectangle rectangle { get; }
    }
}
