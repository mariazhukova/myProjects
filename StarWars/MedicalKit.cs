using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StarWars
{
    class MedicalKit : BaseObject
    {
        Image image;
        Random rnd = new Random(100);
        public MedicalKit(Point pos, Point dir, Size size) : base(pos, dir, size) => image = Image.FromFile("medkit.jpg");
        public override void Draw() => Game.buffer.Graphics.DrawImage(image, pos.X, pos.Y);
        public override void Update()
        {
            pos.X = dir.X;
            if (pos.X < 0) { pos.X = Game.Width + 20; pos.Y = Game.rnd.Next(0, Game.Height); }
        }
    }
}
