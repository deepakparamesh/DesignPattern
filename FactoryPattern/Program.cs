namespace Com.DeepakParamesh
{
    public class Program
    {

        public interface INotification
        {
            void sendNotification();
        }

        // Concrete classes
        public class EmailNotification : INotification
        {
            public void sendNotification()
            {
                Console.WriteLine("Notification sent through Email");
            }
        }

        public class SMSNotification : INotification
        {
            public void sendNotification()
            {
                Console.WriteLine("Notification sent through SMS");
            }
        }

        public class MobileNotification : INotification
        {
            public void sendNotification()
            {
                Console.WriteLine("Notification sent through Mobile");
            }
        }

        public class NotificationFactory
        {
            public INotification getNotification(string notificationType)
            {
                if(notificationType == "EMAIL")
                {
                    return new EmailNotification();
                } else if(notificationType == "SMS")
                {
                    return new SMSNotification();
                } else if(notificationType == "MOBILE")
                {
                    return new MobileNotification();
                } else
                {
                    return null;
                }
            }
        }

        public static void Main()
        {
            NotificationFactory notificationFactory = new();

            INotification notification = notificationFactory.getNotification("MOBILE");
            notification.sendNotification();

            notification = notificationFactory.getNotification("EMAIL");
            notification.sendNotification();

            notification = notificationFactory.getNotification("SMS");
            notification.sendNotification();
        }
    }
}