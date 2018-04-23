using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake
    {
        List<Point> snakeList;
        public Direction _direction;

        public Snake(Point start, int lenght, Direction direction)
        {
            snakeList = new List<Point>();
            _direction = direction;

            for (int i=0; i<lenght;i++)
            {
                Point p = new Point(start);
                p.MovePoint(i,direction);
                snakeList.Add(p);
            }
            foreach (Point p in snakeList)
            {
                p.Draw();
            }
        }
        
        internal void Move()
        {
            Point tail=snakeList.First<Point>();
            Point head = snakeList.Last<Point>();
            Point newpoint = NewPoint(head);
            snakeList.Add(newpoint);
            snakeList.Remove(tail);

            tail.Clean();
            newpoint.Draw();

        }

        private Point NewPoint(Point oldpoint)
        {
            Point temppoint = new Point(oldpoint.x, oldpoint.y);
            temppoint.MovePoint(1, _direction);
            Point newpoint = temppoint;
            return newpoint;
        }

        /// <summary>
        /// read the button to find the direction
        /// </summary>
        /// <param name="key"></param>
        public void ReaKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    _direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    _direction = Direction.RIGHT;
                    break;
                case ConsoleKey.DownArrow:
                    _direction = Direction.DOWN;
                    break;
                case ConsoleKey.UpArrow:
                    _direction = Direction.UP;
                    break;

            }
        }

        public void Feed()
        {
            Point tail = snakeList.Last();
            Point addtail = NewPoint(tail);
            snakeList.Insert(0,addtail);
        }

        public bool IsCross(Food food)
        {
            Point head = snakeList.Last<Point>();
            if (head.x == food.point.x && head.y == food.point.y)
                return true;
            return false;

        }

        public bool IsCross(List<Point> pList)
        {
            Point head = snakeList.Last<Point>();
            foreach (var p in pList)
            {
                if (head.x == p.x && head.y == p.y)
                    return true;
            }
            return false;
        }

        public bool IsCross()
        {
            Point head = snakeList.Last<Point>();
            for(int i =0; i<snakeList.Count-2;i++)
            {
                if (head.IsCross(snakeList[i]))
                    return true;
            }
            return false;
        }
    }


    }

