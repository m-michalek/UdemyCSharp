using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace PolymorphismWithInterfaces
{
    // public class VideoEncoder
    // {
    //     private readonly MailService _mailService;
    //     public VideoEncoder()
    //     {
    //         _mailService = new MailService();
    //     }
    //     
    //     public void Encode(Video video)
    //     {
    //         // Video encoding logic
    //         // ...
    //
    //         _mailService.Send(new Mail());
    //     }
    // }

    public class VideoEncoder
    {
        // List<INotificationChannel> in this case means, the list has to consist out of classes which implement the
        // interface INotificationChannel. This is an example of loosely coupled relation ship because we dont say
        // it has to be a specific notification channel like MailNotificationChannel. Similar to the chef example we would say we 
        // want a chef with x and y capabilities instead of saying we want John.
        // We also make use of polymorphism because we have different implementations/behavior depending of the class
        // which implements the interface INotificationChannel.
        private readonly List<INotificationChannel> _notificationChannels = new List<INotificationChannel>();

        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding video: {video.Title}");
            
            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}