using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Hero
    {
        Wepon Wepon { get; set; }

        Movement Movement { get; set; }

     
        public Hero(HeroAbstractFactory factory)
        {
            Wepon = factory.Wepon();
            Movement = factory.Movement();

        }

        public void Shoot()
        {
            Wepon.Shoot();
        }

        public void Run()
        {
            Movement.Move();
        }

    }
}
