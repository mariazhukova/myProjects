using snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 80;
            int hight = 40;
            int score = 0;
            int speed = 100;
            Console.SetWindowSize(width, hight);
            Console.SetBufferSize(width, hight);
            Walls walls = new Walls(width, hight);

            Point startSnake = new Point(4, 5);
            Snake snake = new Snake(startSnake,5,Direction.RIGHT);
            Food food = new Food(width, hight);
            food.FoodCreate();

            while (true)
            {
                if(walls.IsCross(snake) || snake.IsCross())
                {
                    Console.SetCursorPosition(width / 2, hight / 2);
                    Console.WriteLine("Your score is {0}", score);
                    break;
                }
               if (snake.IsCross(food))
               {
                    snake.Feed();
                    food.FoodCreate();
                    score++;
                    if (speed == 20)
                    { Console.SetCursorPosition(width / 2, hight / 2);
                        Console.WriteLine("You won");
                    }
                    else { speed = speed - 10; }
               }
               else { snake.Move(); }
                Thread.Sleep(speed);

                if(Console.KeyAvailable)
                {

                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ReaKey(key.Key);
                }
                
            }

            Console.ReadKey();
        }

     }
}
