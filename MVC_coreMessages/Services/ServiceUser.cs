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
    class ServiceUser:Service
    {
        XDocument xDocument = null;
        XElement users = null;
        XElement user = null;
        XAttribute attribute = null;
        int maxId = 0;
        public ServiceUser(ref User User)
        {
            if (!File.Exists("./Messages.xml"))
            {
                //xDocument = new XDocument();
                CreateFile(maxId);
            }
            else
            {
                xDocument = XDocument.Load("./Messages.xml");
                CreateNewUser(ref User);
            }
            
        }
        private void CreateNewUser(ref User User)
        {      
            AddUser();
            User.Id = maxId;
        }

        private void AddUser()
        {
            Users users = null;
            
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
       
    }
}
