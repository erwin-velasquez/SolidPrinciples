using System;

namespace LSP1
{
    public class EmailNotificationSender
    {
        public void SendNotification(string message)
        {
            // email component used and sent notification message
            Console.WriteLine($"Sent email: {message}");
        }
    }
}