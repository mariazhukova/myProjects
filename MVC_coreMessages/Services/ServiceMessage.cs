using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using MVC_coreMessages.Models;
using System.Xml.Serialization;
using System.Xml;

namespace MVC_coreMessages.Services
{
    class ServiceMessage:Service
    {
        XDocument xDocument = null;
     
        int maxIdMessage = 0;
        int maxIdUser = 0;
        int userIdTempData { get; set; }

        public ServiceMessage(int UserId ,string message)
        {
            userIdTempData = UserId;
            string res = sendtheMessage(message);
        }

        private string sendtheMessage(string message)
        {
            if (!File.Exists("./Messages.xml"))
            {
                //xDocument = new XDocument();
                return CreateaFile(message);
            }
            else
            {
                xDocument = XDocument.Load("./Messages.xml");
                return AddMessage(message);
            }
        }

        private string AddMessage(string messageBody)
        {
            Users users = null;
            Message newMessageBody = null;
            try
            {
                var serializer = new XmlSerializer(typeof(Users));

                using (var reader = XmlReader.Create("Messages.xml"))
                    users = (Users)serializer.Deserialize(reader);

                if (users.AllUsers.Select(x => x.Id == userIdTempData) != null)
                {
                    maxIdMessage = users.AllUsers.Where(n=>n.Id==userIdTempData).Single().Messages.Max(m => m.Id);
                    newMessageBody = new Message() { Id = maxIdMessage + 1, MessageBody = messageBody };
                    users.AllUsers.Where(x => x.Id == userIdTempData).Single().Messages.Append(newMessageBody);
                }
                else
                {
                    maxIdUser = users.AllUsers.Max(u => u.Id);
                    User newUser = new User()
                    {
                        Id = maxIdUser + 1,
                        Messages = new List<Message>()
                    };
                    newUser.Messages.Add(new Message() { Id = 0, MessageBody = messageBody });
                    users.AllUsers.Append(newUser);
                }
                
                // Serialize.
                using (Stream outputStream = File.OpenWrite("Messages.xml"))
                    serializer.Serialize(outputStream, users);
                return "Message was sent";
            }
            catch(Exception ex)
            {
                return "An error is {0}" + ex.Message;
            }
        }

 
    }
}
