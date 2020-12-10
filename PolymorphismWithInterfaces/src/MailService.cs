using System;

namespace PolymorphismWithInterfaces
{
    internal class MailService
    {
        public void Send(Mail mail)
        {
            Console.WriteLine("Sending mail...");
        }
    }
}