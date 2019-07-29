using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_coreMessages.Services
{
    interface IServiceMessage
    {
        int sendMessage(string message, int UserId);
    }
}
