using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    class Game
    {
        static BufferedGraphicsContext context;
        static public BufferedGraphics buffer;
        static List<Asteroid> asteroids;
        static Image image = Image.FromFile("space.jpg");
        static Bullet bullet;
        static public Random rnd;
        static public int Width { get; set; }
        static public int Height { get; set; }

        static Game(){}

        static public void Init(Form form)
         {
            Graphics g;
        context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            Width = form.Width;
            Height = form.Height;
            buffer = context.Allocate(g, new Rectangle(0, 0, Width, Height));
            Timer timer = new Timer();
        timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
            Load();
        }
        

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Update();
            Draw();
        }

        static public void Update()
        {
            foreach (Asteroid obj in asteroids)
            {
                obj.Update();
            }
            bullet.Update();
            
        }
        
        static public void Draw()
        {
            //buffer.Graphics.Clear(Color.Black);
            buffer.Graphics.DrawImage(image, new Point());
            foreach (Asteroid obj in asteroids)
            {
                if(obj.Collision(bullet))
                {
                    System.Media.SystemSounds.Hand.Play();
                    obj.MoveAsteroid();
                }
                obj.Draw();
            }
            bullet.Draw();
            buffer.Render();
        }

        static public void Load()
        {
            asteroids = new List<Asteroid>(30);
            rnd = new Random();
            bullet = new Bullet(new Point(0, 200), new Point(5, 0), new Size(4, 1));
                
            for (int i = 0; i < asteroids.Count; i++)
                asteroids[i] = new Asteroid(new Point(800, rnd.Next(Height)), new Point(rnd.Next(0,10)-15,0), new Size(20, 20));
            

        }
    }   
}
