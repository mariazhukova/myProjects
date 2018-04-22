using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            try
            {
                int width = 800;
                int height = 600;
                form.Width = width;
                form.Height = height;
               
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exaption {0}" + ex);
            }
            finally
            {

                Game.Init(form);
                form.Show();
                Game.Draw();
                Application.Run(form);
            }
        }
    }
}
