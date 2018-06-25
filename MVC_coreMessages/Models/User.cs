using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MVC_coreMessages.Models
{
    public class User
    {
        [XmlAttribute]
        public int Id { get; set; }
        [XmlElement]
        public List<Message> Messages {get;set;}
    }
}
