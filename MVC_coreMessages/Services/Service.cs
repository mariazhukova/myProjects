using MVC_coreMessages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MVC_coreMessages.Services
{
    public class Service : IService
    {
        public string CreateaFile(string message)
        {
            return SerializeToFile(messageBody: message);

        }

        public string CreateFile(int IdUser)
        {
            return SerializeToFile(IdUser);
        }

        private string SerializeToFile(int Id = 0, string messageBody="")
        {
            try
            {
                User newUser = new User() { Id = Id, Messages = new List<Message>().Append(new Message() { Id = 0, MessageBody = messageBody }) };

                var serializer = new XmlSerializer(newUser.GetType());
                using (var writer = XmlWriter.Create("Messages.xml"))
                {
                    serializer.Serialize(writer, newUser);

                }
                return "Ok";
            }
            catch (Exception ex)
            {
                return "An error is {0}" + ex.Message;
            }

        }
    }
}
