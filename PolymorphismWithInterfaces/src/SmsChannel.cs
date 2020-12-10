using System;

namespace PolymorphismWithInterfaces
{
    public class SmsChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending sms...");
        }
    }
}