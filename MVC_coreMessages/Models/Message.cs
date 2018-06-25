using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MVC_coreMessages.Models
{
    public class Message
    {
        [XmlAttribute]
        public int Id { get; set; }
        [XmlElement]
        public string MessageBody { get; set; }
    }
}
