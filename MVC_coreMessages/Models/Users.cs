using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MVC_coreMessages.Models
{
    [XmlRoot("Messages")]
    public class Users
    {
        [XmlElement]
        public List<User> AllUsers { get; set; }
    }
}
