using Adapter_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Model
{
    public class Sms : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sending Sms.....");
        }
    }
}
