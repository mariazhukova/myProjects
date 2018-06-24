using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_coreMessages.Services
{
    interface IService
    {
        string CreateaFile(string message);
        string CreateFile(int IdUser);
    }
}
