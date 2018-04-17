using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StarWars
{
    class Ship : BaseObject
    {
        int energy = 100;
        Image image;
        public static event Message MessageDie;
        public int Energy { get; set; }
        public Ship (Point pos, Point dir, Size size) :base(pos,dir,size) => image = Image.FromFile("ship21.png");
        
        public override void Draw()=> Game.buffer.Graphics.DrawImage(image, pos.X, pos.Y);

        public override void Update()
        {
            base.Update();
        }

        public void Up()
        {
            if (pos.Y < 0) pos.Y = pos.Y;
            else pos.Y = pos.Y - dir.Y;
        }
        public void Down()
        {
            if (pos.Y > Game.Height) pos.Y = pos.Y;
            else pos.Y = pos.Y + dir.Y;
        }
        public void Left()
        {
            if (pos.X < 0) pos.X = pos.X;
            else pos.X = pos.X - dir.X;
        }
        public void Right()
        {
            if (pos.X > Game.Width) pos.X = pos.X;
            else pos.X = pos.X + dir.X;
        }
        public void Die()
        {
            MessageDie?.Invoke();

        }
    }
}
