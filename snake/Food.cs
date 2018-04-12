using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Food
    {
        Random random;
       public Point point;
        private int width;
        private int hight;

        public Food(int width, int hight)
        {
            this.width = width;
            this.hight = hight;
        }

        public void FoodCreate()
        {
            random = new Random();
            int y = random.Next(hight / 3, hight);
            int x = random.Next(width / 3, width);
            point = new Point(x,y);
            point.Draw();
        }
    }
}
