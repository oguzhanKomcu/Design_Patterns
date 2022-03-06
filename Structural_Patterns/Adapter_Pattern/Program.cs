using Adapter_Pattern.Adapter;
using Adapter_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {


            SendNotification  notification = new SendNotification();
            notification.Send_Notification(new Email());
            notification.Send_Notification(new Sms());
            notification.Send_Notification(new PushNotificationAdepter());

            Console.ReadLine();




        }
    }
}
