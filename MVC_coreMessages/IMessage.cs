using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_coreMessages
{
    interface IMessage
    {
        string sendtheMessage(string message);
        string GetMessages(int IdUser);

    }
}
