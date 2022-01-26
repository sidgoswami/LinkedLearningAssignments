using System;
using System.Collections.Generic;
using System.Text;

namespace HPlusSports.Core
{
    class SMSNotifyUser : INotifyService
    {
        public void NotifyUser(int id)
        {
            Console.WriteLine($"Sending sms notification to user with ID {id}");
        }
    }
}
