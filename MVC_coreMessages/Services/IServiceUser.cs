using MVC_coreMessages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_coreMessages.Servises
{
    interface IServiceUser
    {
        Models.User CreateNewUser(User User);
        
    }
}
