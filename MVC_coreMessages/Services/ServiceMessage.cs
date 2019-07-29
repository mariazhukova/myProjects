using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using MVC_coreMessages.Models;
using System.Xml.Serialization;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using MVC_coreMessages.Servises;

namespace MVC_coreMessages.Services
{
    class ServiceMessage: Service,IServiceMessage
    {
        ServiceUser serviceUser = new ServiceUser();
        public ServiceMessage()
        {
        }


        private int GetMaxMessageNumber(int userId)
        {
            int nextMessageId = 0;
            try
            {
                nextMessageId=(serviceUser.GetUsers().AllUsers.Where(u => u.Id == userId).SelectMany(m => m.Messages).Max(m => m.Id))+1;
            }
            catch (Exception ex)
            {
               
            }
            return nextMessageId;
        }

        public int sendMessage(string message, int UserId = 0)
        {
            int userId = UserId;
            if (!File.Exists("./Messages.xml"))
            {
                SerializeToFile(userId, message);
            }
            else if(userId == 0)
            {
                userId = serviceUser.CreateNewUserID();
                int firstmessage = 1;
                AddMessage(userId, firstmessage, message);
            }
            else
            {
                int nextMessageId = GetMaxMessageNumber(userId);
               AddMessage(userId, nextMessageId, message);
            }
            return userId;
        }
       private string AddMessage(int userid,int messageid,string messageBody)
        {
            Message newMessage = null;
           try
            {
                newMessage = new Message() { Id = messageid, MessageBody = messageBody };

                return serviceUser.AddMessageToUser(userid, newMessage) == "Ok" ? "Message was sent" : throw new Exception("Error in a serialization process");
            }
            catch(Exception ex)
            {
                return "An error is {0}" + ex.Message;
            }
        }
      
    }
}
