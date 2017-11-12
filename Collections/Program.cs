using System;
using System.Collections;
using System.Collections.Specialized;

namespace Collections
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ArrayList users = new ArrayList();
            string user = null;
          
            do
            {
                Console.WriteLine("Enter the users:");
                user = Console.ReadLine();
                users.Add(user.Trim());

            }
            while (!string.IsNullOrEmpty(user));

            foreach (string u in users)
                Console.WriteLine(u);
        }


    }



}