using System;

namespace DIP
{
    public interface INotificationSender
    {
        void SendNotification(string message);
    }
}