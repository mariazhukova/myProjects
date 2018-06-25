using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_coreMessages.Models;
using MVC_coreMessages.Servises;
using static System.Net.WebRequestMethods;
using System.Web;

namespace MVC_coreMessages.Controllers
{
    public class UserController : Controller
    {
        ServiceUser serviseUser = null;
        User user = null;
        public UserController()
        {
            CreateNewUser();
        }
      
        private void CreateNewUser()
        {
            user = new User();
            serviseUser = new ServiceUser(ref user);
            TempData["User"] = user.Id;
        }



    }
}