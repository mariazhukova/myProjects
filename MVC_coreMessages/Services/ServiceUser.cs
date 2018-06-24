using MVC_coreMessages.Models;
using MVC_coreMessages.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            var items = from xel in xDocument.Element("AllUsers").Elements("User")
                        select new User { Id = Int32.Parse(xel.Attribute("Id").Value) };
            maxId = items.Max(x => x.Id);
           
            XElement root = xDocument.Element("AllUsers");
            root.Add(new XElement("User", new XAttribute("Id", ++maxId)));
            
        }
       
    }
}
