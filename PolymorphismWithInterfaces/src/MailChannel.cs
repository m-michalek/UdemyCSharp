using System;

namespace PolymorphismWithInterfaces
{
    public class MailChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail...");
        }
    }
}