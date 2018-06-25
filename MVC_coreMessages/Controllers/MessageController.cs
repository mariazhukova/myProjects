using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_coreMessages.Models;
using MVC_coreMessages.Services;
using MVC_coreMessages.Servises;

namespace MVC_coreMessages.Controllers
{
    public class MessageController : Controller
    {
        ServiceMessage service = null;
        ServiceUser serviceUseer = null;
        User user = null;
        public string GetMessages(int IdUser)
        {
            throw new NotImplementedException();
        }
      
        public IActionResult SendMessage()
        {
            Request.Query.Keys.Contains("MessageBody");

            int res = 0;

            if (user== null)
            {
                user = new User();
                serviceUseer = new ServiceUser(ref user);
                
            }
            else
            {
                Int32.TryParse(TempData["User"].ToString(), out res);
                service = new ServiceMessage(res, "");
            }
           
            return View();
        }

        public IActionResult sendtheMessage()
        {
         
            //Int32.TryParse(TempData["User"].ToString(), out res);
            
            service = new ServiceMessage(0, "");
            return View("ResultMessage");
        }




    }
}