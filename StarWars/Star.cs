using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    class Star : BaseObject
        
    {
        Image image;    
        Pen color;

        public Star(Point pos, Point dir, Size size,Pen color) : base(pos, dir, size)
        {
            this.color = color;
            image = Image.FromFile("asteroid2.png");
        }

        //public Star(Point pos, Point dir, Size size, Pen color) => this.color = color;

        public override void Draw()=>Game.buffer.Graphics.DrawImage(image, pos.X, pos.Y, size.Width, size.Height);
        
    }
}
