using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace StarWars
{
    class Game
    {
        static Ship ship = new Ship(new Point(10, 200), new Point(5, 5), new Size(10, 10));
        static BufferedGraphicsContext context;
        static public BufferedGraphics buffer;
        static List<Asteroid> asteroids;
        static List<MedicalKit> Mkits;
        static Image image = Image.FromFile("space.jpg");
        static Image gameover = Image.FromFile("gameover.jpg");
        static List<Bullet> bullets=new List<Bullet>();
        static public Random rnd;
        static int score = 0;
        static int iteration = 0;
        static string fileName = "LogFile.txt";
        static string path = AppDomain.CurrentDomain.BaseDirectory + @"\" + fileName;
        static Timer timer = new Timer();
        /// <summary>
        /// Append message to the existed file
        /// </summary>
        /// <param name="message"></param>
        delegate void WrirteLog(string message);
        static public int Width { get; set; }
        static public int Height { get; set; }
        static WrirteLog log = new WrirteLog(FullLog);


        static Game(){}

        static public void Init(Form form)
         {
            Graphics g;
        context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            Width = form.Width;
            Height = form.Height;
            buffer = context.Allocate(g, new Rectangle(0, 0, Width, Height));
            
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
            Load();
            form.KeyDown += Form_KeyDown;
            Ship.MessageDie += Finish;
        }

        private static void Finish()
        {
            timer.Stop();
        }

        private static void FullLog(string message)
        {
           try
           {

               using (StreamWriter file = new StreamWriter(path, true, System.Text.Encoding.Default))
               {
                   file.WriteLineAsync("Start game: ");
                   file.WriteLine("{0}:{1}",iteration,message);
                   iteration++;
               }
           }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
            
        }
        private static void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) bullets.Add( new Bullet(new Point(ship.rectangle.X + 10, ship.rectangle.Y + 4), new Point(4, 0), new Size(4, 1)));
            if (e.KeyCode == Keys.Up) ship.Up();
            if (e.KeyCode == Keys.Down) ship.Down();
            if (e.KeyCode == Keys.Left) ship.Left();
            if (e.KeyCode == Keys.Right) ship.Right();
        }
        
       
        private static void Timer_Tick(object sender, EventArgs e)
        {
            Update();
            Draw();
        }

        static public void Update()
        {
            for (int iter = 0; iter < bullets.Count; iter++)
            {
                for (int i = 0; i < asteroids.Count; i++)
                {
                    if (asteroids[i] != null)
                    {
                        asteroids[i].Update();
                        if (bullets[iter] != null && bullets[iter].Collision(asteroids[i]))
                        {
                            System.Media.SystemSounds.Hand.Play();
                            bullets.Remove(bullets[iter]);
                            iter--;
                            asteroids.Remove(asteroids[i]);
                            i--;
                            score += 10;
                            log("Shot, plus 10 to score");
                            continue;
                        }
                        if (ship.Collision(asteroids[i]))
                        {
                            if (ship.Energy < 10)
                            {
                                ship.Energy -= 10;
                                System.Media.SystemSounds.Hand.Play();
                                log("Ship was injured");
                            }

                        }
                    }
                }
            }
            for (int it=0;it<Mkits.Count;it++)
            {
                if(Mkits[it]!=null)
                {
                    if(Mkits[it].Collision(ship))
                    {
                        Mkits.Remove(Mkits[it]);
                        it--;
                        ship.Energy += 10;
                        log("You have taken the medical kit,plus 10 to score");
                    }
                }
            }
           
            
        }
        
        static public void Draw()
        {
            buffer.Graphics.DrawImage(image, new Point());
            foreach (Bullet b in bullets)
            {
                foreach (Asteroid obj in asteroids)
                {
                    if (obj != null)
                    {
                        if (obj.Collision(b))
                        {
                            System.Media.SystemSounds.Hand.Play();
                            score += 10;
                            b.Reset(ship.rectangle.X, ship.rectangle.Y);
                        }
                    }
                    obj.Draw();
                }
            }
            foreach(MedicalKit kit in Mkits)
            {
                if(kit!=null)
                {
                    if (kit.Collision(ship))
                    {
                        ship.Energy += 10;
                    }
                }
            }
            //if (bullet!=null) bullet.Draw();
            buffer.Graphics.DrawString("Energy: {0}" + ship.Energy, SystemFonts.DefaultFont, Brushes.White, 0, 0);
            buffer.Render();
        }

        static public void Load()
        {

            File.Create(path);
            asteroids = new List<Asteroid>(30);
            Mkits= new List<MedicalKit>(5);
            rnd = new Random();

            //bullet = new Bullet(new Point(0, 200), new Point(5, 0), new Size(4, 1));
            log("All objects have been loaded");
                
            for (int i = 0; i < asteroids.Count; i++)
                asteroids[i] = new Asteroid(new Point(800, rnd.Next(Height)), new Point(rnd.Next(0,10)-15,0), new Size(30, 30));
            for (int it = 0; it < Mkits.Count; it++)
                Mkits[it] = new MedicalKit(new Point(800, rnd.Next(Height)), new Point(rnd.Next(0, 10) - 15, 0), new Size(20, 30));
            
        }
        static public void GameOver()
        {
            buffer.Graphics.DrawImage(gameover, new Point());
            buffer.Graphics.DrawString("Your score is: {0}" + score, SystemFonts.DefaultFont, Brushes.White, 400,300);
            ship.Die();
        }
    }   
}
