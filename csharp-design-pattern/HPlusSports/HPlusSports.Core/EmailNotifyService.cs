using System;
using System.Collections.Generic;
using System.Text;

namespace HPlusSports.Core
{
    public class EmailNotifyService : INotifyService
    {
        public void NotifyUser(int id)
        {
            Console.WriteLine($"Sending email notification to user with ID {id}");
        }
    }
}
