using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using MVC_coreMessages.Models;
using System.Xml.Serialization;
using System.Xml;
using Microsoft.AspNetCore.Mvc;

namespace MVC_coreMessages.Services
{
    class ServiceMessage
    {
        int maxIdMessage = 0;
        int maxIdUser = 0;
        int userIdTempData { get; set; }

        public ServiceMessage()
        {
        }


        public string sendMessage(int UserId,string message)
        {
            userIdTempData = UserId;
            if (!File.Exists("./Messages.xml"))
            {
                return SerializeToFile(messageBody:message);
            }
            else
            {
                return AddMessage(message);
            }
        }

        public int sendMessage(string message)
        {
            if (!File.Exists("./Messages.xml"))
            {
                SerializeToFile(messageBody: message);
                userIdTempData = 0;
            }
            else
            {
                userIdTempData = CreateNewUserID();
                AddMessage(message);
            }
            return userIdTempData;
        }

        private string SerializeToFile(int Id = 0, string messageBody = "")
        {
            try
            {
                User newUser = new User() { Id = Id, Messages = new List<Message>() { new Message() { Id = userIdTempData, MessageBody = messageBody } } };
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

        private string AddMessage(string messageBody)
        {
            Users users = null;
            Message newMessageBody = null;
            try
            {
                var serializer = new XmlSerializer(typeof(Users));

                using (var reader = XmlReader.Create("Messages.xml"))
                    users = (Users)serializer.Deserialize(reader);
                newMessageBody = new Message() { Id = maxIdMessage + 1, MessageBody = messageBody };
                maxIdMessage = users.AllUsers.Where(n => n.Id == userIdTempData).Single().Messages.Max(m => m.Id);
                users.AllUsers.Where(x => x.Id == userIdTempData).Single().Messages.Add(newMessageBody);
                                
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

        
        public List<Message> GetMessagesbyUserId(int userid)
        {
            Users users = null;
            List<Message> messages = new List<Message>();
            try
            {
                var serializer = new XmlSerializer(typeof(Users));

                using (var reader = XmlReader.Create("Messages.xml"))
                    users = (Users)serializer.Deserialize(reader);

                if (users.AllUsers.Select(x => x.Id == userIdTempData) != null)
                    messages = users.AllUsers.Where(n => n.Id == userIdTempData).Single().Messages;
            }
            catch (Exception ex) {  /*Create method to track errors*/}
            return messages;
        }

        public List<Message> GetAllMessages()
        {
            Users users = null;
            List<Message> messages = new List<Message>();
            try
            {
                var serializer = new XmlSerializer(typeof(Users));
                if (File.Exists("./Messages.xml")) {
                    using (var reader = XmlReader.Create("Messages.xml"))
                        users = (Users)serializer.Deserialize(reader);
                   foreach(var u in users.AllUsers)
                        foreach (var m in u.Messages)
                            messages.Add(m);
                } else { messages = null; }
            }
            catch (Exception ex) {  /*Create method to track errors*/}
            return messages;
        }
        private int CreateNewUserID()
        {
            Users users = null;
            try
            {
                var serializer = new XmlSerializer(typeof(Users));

                using (var reader = XmlReader.Create("Messages.xml"))
                    users = (Users)serializer.Deserialize(reader);
                return users.AllUsers.Max(u => u.Id);
                
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

 
    }
}
