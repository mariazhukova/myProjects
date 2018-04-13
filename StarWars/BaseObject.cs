using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
   abstract class BaseObject:ICollision
    {
       public delegate void Message();
        protected Point pos;
        protected Point dir;
        protected Size size;

        public BaseObject(Point pos,Point dir,Size size)
        {
            this.pos = pos;
            this.dir = dir;
            this.size = size;

        }

        public Rectangle rectangle => new Rectangle(pos,size);

        public bool Collision(ICollision obj)
        {   
            if (obj!=null)
            if (obj.rectangle.IntersectsWith(this.rectangle)) return true; else return false;
            return false;
        }

        abstract public void Draw();
        
        public virtual void Update()
        {
            pos.X = pos.X + dir.X;
            pos.Y = pos.Y + dir.Y;
            if (pos.X < 0 || pos.X > Game.Width) dir.X = -dir.X;
            if (pos.Y < 0 || pos.Y > Game.Height) dir.Y = -dir.Y;
          
        }
    }
}
