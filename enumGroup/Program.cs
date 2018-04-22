using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            User user = new User();
            user.Group = Group.Users;
            user.Group = Group.Supervisors;
            user.Group = Group.Managers;
            User user1 = new User();
            user1.Group = Group.Users;
            user1.Group = Group.Administrations;
            User user2 = new User();
            user2.Group = Group.Users;
            user2.Group = Group.Managers;
            User user3 = new User();
            user3.Group = Group.Users;
            users.Add(user);
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            foreach (User u in users)
            {
                if (u.Group == Group.Managers)
                    Console.WriteLine("true");
                else Console.WriteLine(u.Group);
                if(u.Group < Group.Administrations)
                    Console.WriteLine("true");
                else Console.WriteLine(u.Group);
            }

            Console.ReadKey();
        }
    }

    [System.FlagsAttribute()]
    public enum Group
    {
        Users=1,
        Supervisors=2,
        Managers=4,
        Administrations=8

    }

    public class User
    {
        public Group Group { get; set; }
    }
}
