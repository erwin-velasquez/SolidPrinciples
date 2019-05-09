using System;

namespace DIP
{
    public class EmailNotificationSender : INotificationSender
    {
        public void SendNotification(string message)
        {
            // email component used and sent notification message
            Console.WriteLine($"Sent email: {message}");
        }
    }
}