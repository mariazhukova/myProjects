using MVC_coreMessages.Models;
using MVC_coreMessages.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MVC_coreMessages.Servises
{
    class ServiceUser:Service,IServiceUser
    {
        public Users GetUsers()
        {
            Users users = null;
            try
            {
                var serializer = new XmlSerializer(typeof(Users));

                using (var reader = XmlReader.Create("Messages.xml"))
                    return users = (Users)serializer.Deserialize(reader);
            }
            catch(Exception ex)
            {
                return users = null;
            }
        }

        public string AddMessageToUser(int userId,Message message)
        {
            Users users = null;
            try
            {
                users = GetUsers();
                users.AllUsers.Where(x => x.Id == userId).Single().Messages.Add(message);
                var serializer = new XmlSerializer(typeof(Users));
                // Serialize.
                using (Stream outputStream = File.OpenWrite("Messages.xml"))
                    serializer.Serialize(outputStream, users);
                return "Ok";
            }
            catch(Exception ex)
            {
                return "Error: {0}" + ex.Message;
            }
           
        }
        private void AddUser()
        {
            Users users = null;
            int maxId = 0;
            try
            {
                var serializer = new XmlSerializer(typeof(Users));

                using (var reader = XmlReader.Create("Messages.xml"))
                    users = (Users)serializer.Deserialize(reader);
                maxId = users.AllUsers.Max(x => x.Id);
                users.AllUsers.Add(new User { Id = maxId + 1, Messages = new List<Message>() { new Message { Id = 0, MessageBody = "" } } });

                using (Stream output = File.OpenWrite("Messages.xml"))
                    serializer.Serialize(output, users);
            }
            catch(Exception ex)
            {

            }
        }
        public int CreateNewUserID()
        {
            Users users = null;
            int newId = 0;
            try
            {
                var serializer = new XmlSerializer(typeof(Users));

                using (var reader = XmlReader.Create("Messages.xml"))
                    users = (Users)serializer.Deserialize(reader);
                newId = (users.AllUsers.Max(u => u.Id)) + 1;

                return newId;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

    }
}
