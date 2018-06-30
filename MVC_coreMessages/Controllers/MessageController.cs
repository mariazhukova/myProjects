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
        ServiceMessage service = new ServiceMessage();
      
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public JsonResult send(string message)
        {
            if (Request.Cookies["UserId"]==null)
            {
                int Id = service.sendMessage(message);
                Response.Cookies.Append("UserId", Id.ToString());
            }
            else
            {
                int Id = 0;
                Int32.TryParse(Request.Cookies["UserId"], out Id);
                service.sendMessage( message, Id);
            }
            
            return Json("Ok"); 
        }

       public IActionResult GetMessages()
        {
            int UserId = 0;
            Int32.TryParse(Request.Cookies["UserId"], out UserId);
            IEnumerable<Message> messages = service.GetMessages(UserId);
            return PartialView("_showMessages",messages);
        }

        public IActionResult GetAllMessages()
        {
            Users messages = service.GetMessages();
            return PartialView("_showAllMessages", messages);
        }

    }
}