using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    class Asteroid : BaseObject
    {
        Image image;
        Random rnd = new Random(2);

        string[] arrayimg = new string[] { "asteroid2.png", "asteroid.jpg" };

        public Asteroid(Point pos, Point dir, Size size) : base(pos, dir, size) => image = Image.FromFile(arrayimg[rnd.Next()]);
           
        public override void Draw() => Game.buffer.Graphics.DrawImage(image, pos.X, pos.Y);
        //Game.buffer.Graphics.DrawImage(image, pos.X, pos.Y, size.Width, size.Height);
        public override void Update()
        {
            pos.X += dir.X;
            if (pos.X < 0) { pos.X = Game.Width + 20;pos.Y = Game.rnd.Next(0, Game.Height); }
        }

        public void MoveAsteroid()
        {
            pos.X= Game.Width + 20;
            pos.Y= Game.rnd.Next(0, Game.Height);
        }

    }
}
