using MVC_coreMessages.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MVC_coreMessages.Services
{
    public class Service : IService
    {
        public string SerializeToFile(int Id = 0, string messageBody = "")
        {
            try
            {
                User newUser = new User() { Id = Id, Messages = new List<Message>() { new Message() { Id = 0, MessageBody = messageBody } } };
                Users users = new Users();
                users.AllUsers = new List<User>() { newUser };

                var serializer = new XmlSerializer(users.GetType());
                using (var writer = XmlWriter.Create("Messages.xml"))
                    serializer.Serialize(writer, users);

                return "Ok";

            }
            catch (Exception ex)
            {
                return "An error is {0}" + ex.Message;
            }

        }
         public Users GetMessages()
        {
            Users users = null;
            try
            {
                var serializer = new XmlSerializer(typeof(Users));
                if (File.Exists("./Messages.xml"))
                {
                    using (var reader = XmlReader.Create("Messages.xml"))
                        users = (Users)serializer.Deserialize(reader);

                }
                else { users = null; }
            }
            catch (Exception ex) {  /*Create method to track errors*/}

            return users;
        }
        public  List<Message> GetMessages(int userId)
        {
            Users users = null;
            try
            {
                var serializer = new XmlSerializer(typeof(Users));
                if (File.Exists("./Messages.xml"))
                {
                    using (var reader = XmlReader.Create("Messages.xml"))
                        users = (Users)serializer.Deserialize(reader);

                }
                else { users = null; }
                if (users.AllUsers.Select(x => x.Id == userId) != null)
                    return users.AllUsers.Where(n => n.Id == userId).Single().Messages;
            }
            catch (Exception ex) {  /*Create method to track errors*/}

            return null;
        }
    }
}
