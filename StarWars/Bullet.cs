﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    class Bullet:BaseObject
    {
        Image image;
        public Bullet(Point pos, Point dir, Size size) : base(pos, dir, size) => image = Image.FromFile("bullet.png");
       
        public override void Draw() => Game.buffer.Graphics.DrawRectangle(Pens.OrangeRed, pos.X, pos.Y, size.Width, size.Height);
        public override void Update() => pos.X = pos.X + 10;
        public void Reset(int x,int y)
        {
            pos.X = x + 5;
            pos.Y = y;
        }
    }
}
