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
       User user = null;

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
                service.sendMessage(Id, message);
            }
            
            return Json("Ok"); 
        }

       public IActionResult GetMessages()
        {
            int UserId = 0;
            Int32.TryParse(Request.Cookies["UserId"], out UserId);
            IEnumerable<Message> messages = service.GetMessagesbyUserId(UserId);
            return PartialView("_showMessages",messages);
        }

        public IActionResult GetAllMessages()
        {
            IEnumerable<Message> messages = service.GetAllMessages();
            return PartialView("_showAllMessages", messages);
        }

        public IActionResult get()
        {
            int UserId = 0;
            Int32.TryParse(Request.Cookies["UserId"], out UserId);
            var messages = service.GetMessagesbyUserId(UserId);
            return PartialView("_showMessages", messages);
        }
    }
}