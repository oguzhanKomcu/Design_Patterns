using Adapter_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Adapter
{
    public class SendNotification
    {

        public void Send_Notification(INotification notification)
        {
               notification.Send();
        }



    }
}
