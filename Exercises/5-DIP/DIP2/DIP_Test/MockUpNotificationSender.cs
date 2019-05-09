using System;
using Xunit;
using DIP;

namespace DIP_Test
{
    public class MockUpNotificationSender : INotificationSender
    {
        public void SendNotification(string message)
        {
            // email component used and sent notification message
            Console.WriteLine($"Mockup email: {message}");
        }
    }
}