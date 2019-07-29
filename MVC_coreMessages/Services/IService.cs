using MVC_coreMessages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_coreMessages.Services
{
    interface IService
    {
        string SerializeToFile(int Id, string messageBody);
        Users GetMessages();
        List<Message> GetMessages(int userId);
    }
}
