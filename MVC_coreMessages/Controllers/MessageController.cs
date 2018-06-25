using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_coreMessages.Services;

namespace MVC_coreMessages.Controllers
{
    public class MessageController : Controller,IMessage
    {
        ServiceMessage service = null;
        public string GetMessages(int IdUser)
        {
            throw new NotImplementedException();
        }

        public IActionResult SendMessage()
        {
            string result = sendtheMessage("");
            return View();
        }

        public string sendtheMessage(string message)
        {
            int res = 0;

            if (TempData["User"] == null)
            {
                RedirectToAction("CreateNewUser", "User");
            }
            else
            {
                Int32.TryParse(TempData["User"].ToString(), out res);
                service = new ServiceMessage(res, message);
            }
            return "Ok";
        }
    }
}