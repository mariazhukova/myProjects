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
        public MedicalKit(Point pos, Point dir, Size size) : base(pos, dir, size) => image = Image.FromFile("kit.png");
        public override void Draw() => Game.buffer.Graphics.DrawImage(image, pos.X, pos.Y);
        public override void Update()
        {
            pos.X = pos.X + dir.X;
            if (pos.X < 0) pos.X = Game.Width + size.Width;


        }
    }
}
