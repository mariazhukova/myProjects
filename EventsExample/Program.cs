using System;

namespace StructuresExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffe newCoffee = new Coffe();
            //we can use structure like Coffe newCoffee; in case we don't have {get;set;} metod
            ClassCoffee classCoffee = new ClassCoffee();

            Console.WriteLine("Do you wamt coffee?");
            string ansver = Console.ReadLine();
            if (ansver == "yes")
            {
                Console.WriteLine("type the type");
                string secondAnsver= Console.ReadLine();
                string name = classCoffee.ClassCoffe(secondAnsver);
                newCoffee.Name = name;
                newCoffee.Bean = true;
                newCoffee.CountryOfOrigin = "New Zeland";
                newCoffee.Streight = 4;

                newCoffee.Show();
                //but it'd better to use Show in the main function
               /* Console.WriteLine("Your coffee name is {0}, is it from beens {1}, where is it from {2}, the streight is {3}",
                   newCoffee.Name, newCoffee.Bean, newCoffee.CountryOfOrigin, newCoffee.Streight);*/

            }
               else Console.WriteLine("goodbye");
                   

            
        }
    }

    struct Coffe
    {
        public string Name{get; set; }
        public bool Bean { get;set;}        
        public string CountryOfOrigin { get; set; }
        public int Streight { get; set; }

        //in any structure, you must to initialize all fields. In class you don't have such strong rules
        public Coffe(string Name,bool Bean,string CountryOfOrigin,int Streight)
        {
            this.Name = Name;
            this.Bean = Bean;
            this.CountryOfOrigin = CountryOfOrigin;
            this.Streight = Streight;
        }
        public void Show()
        {
            Console.WriteLine("Your coffee name is {0}, is it from beens {1}, where is it from {2}, the streight is {3}",
                    Name, Bean, CountryOfOrigin, Streight);
        }
    }

    class ClassCoffee
    {
        enum classCoffe:short { Capuchino, Americano, WithMilk, GreenCoffee}

        public string ClassCoffe (string description)
        {
            classCoffe name = (classCoffe)System.Enum.Parse(typeof(classCoffe),description);

            return name.ToString();
        }

        

    }

}