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
        static string path = AppDomain.CurrentDomain.BaseDirectory  + fileName;
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

               using (FileStream stream = new FileStream(path, FileMode.Open,FileAccess.Read,FileShare.ReadWrite))
               {
                    using (StreamWriter sw = new StreamWriter(stream))
                    {
                        byte[] array = System.Text.Encoding.Default.GetBytes(iteration + ":" + " " + message);
                        stream.Write(array, 0, message.Length);
                        iteration++;
                    }
               }
               
            }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
            finally
            {
               // stream.Close();
            }
            
        }
        private static void Form_KeyDown(object sender, KeyEventArgs e)
         {
            if (e.KeyCode == Keys.ControlKey)
                bullets.Add(new Bullet(new Point(ship.rectangle.X + 10, ship.rectangle.Y + 4), new Point(4, 0), new Size(10, 5))); 
          
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
            foreach (Bullet obj in bullets)
                obj.Update();

            //we need to process with a collision between bullets and asteroids

            for (int i = 0; i < asteroids.Count; i++)
            {
                if (asteroids[i] != null)
                    asteroids[i].Update();
                for (int iter = 0; iter < bullets.Count; iter++)
                {
                    {  if (bullets[iter] != null && bullets[iter].Collision(asteroids[i]))
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
                        
                    }
                  
                }
                
            }
            for (int i = 0; i < asteroids.Count; i++)
            {
                if (ship.Collision(asteroids[i]))
                {
                    ship.EnergyLow(10);
                }
            }

            if (ship.Energy < 50)
            {
                for (int it = 0; it < Mkits.Count; it++)
                {
                    if (Mkits[it] != null)
                    {
                        Mkits[it].Update();
                        if (ship.Collision(Mkits[it]))
                        {
                            Mkits.Remove(Mkits[it]);
                            it--;
                            ship.EnergyMore(10);
                            if (ship.Energy > 100) ship.Energy = 100;
                            log("You have taken the medical kit,plus 10 to score");
                        }
                    }

                }
            }
           
            
        }
        
        static public void Draw()
        {
            buffer.Graphics.DrawImage(image, new Point());
            ship.Draw();

            foreach (Bullet bul in bullets)  bul.Draw();
            
            foreach (Asteroid obj in asteroids)
            {
                if (obj != null)
                { obj.Draw(); }
            }

            if (ship.Energy < 0) GameOver();

            if (ship.Energy < 30) foreach (MedicalKit med in Mkits)
                        if (med != null) med.Draw();

            if (ship.Energy < 50)
            {
                foreach (MedicalKit kit in Mkits)
                {
                    if (kit != null)
                    {
                        if (kit.Collision(ship))
                        {
                            ship.EnergyMore(10);
                        }
                    }
                    kit.Draw();
                }
            }
            buffer.Graphics.DrawString("Energy:" + ship.Energy, SystemFonts.DefaultFont, Brushes.White, 0, 0);
            buffer.Render();
        }
   

        static public void Load()
        {

            File.Create(path);
            asteroids = new List<Asteroid>(30);
            Mkits= new List<MedicalKit>(5);
            rnd = new Random();
            ship.Draw();
            ship.Energy = 100;
            log("All objects have been loaded");
            for (int i = 0; i < 15; i++)
                asteroids.Add(new Asteroid(new Point(800, rnd.Next(Height)), new Point(rnd.Next(0,10)-15,0), new Size(30, 30)));
            for (int it = 0; it < 3; it++)
                Mkits.Add(new MedicalKit(new Point(800, rnd.Next(Height)), new Point(rnd.Next(0, 10) - 15, 0), new Size(30, 30)));
            
        }
        static public void GameOver()
        {
            timer.Stop();
            buffer.Render();
            buffer.Graphics.Clear(Color.Black);
            buffer.Graphics.DrawImage(gameover, new Point(200,150));
            buffer.Graphics.DrawString("Your score is: " + score, SystemFonts.DefaultFont, Brushes.White, 600,300);
            ship.Die();
        }
    }   
}
