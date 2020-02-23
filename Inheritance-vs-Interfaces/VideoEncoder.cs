using System.Collections;
using System.Collections.Generic;

namespace Inheritance_vs_Interfaces
{
    public class VideoEncoder
    {
        private readonly IList<INotification> _notificationSubscriptions;

        public VideoEncoder()
        {
            _notificationSubscriptions = new List<INotification>();
        }
        public void Message()
        {
            foreach (var subscription in _notificationSubscriptions)
            {
                subscription.Message(new MessageText());
            }
        }

        public void Subscribe(INotification notification)
        {
            _notificationSubscriptions.Add(notification);
        }
    }
}