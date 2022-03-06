using Adapter_Pattern.Interface;
using Adapter_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Adapter
{
    public class PushNotificationAdepter : INotification
    {
        public void Send()
        { 
            CustomerRecord customer  = new CustomerRecord();
            customer.Create();
            customer.Log_Text();
            customer.GetAll();
            
        }
    }
}
