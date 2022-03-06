using Adapter_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Model
{
    public class CustomerRecord
    {

        public void Create()
        {
            Console.WriteLine("The client has been created.");
  
        }

        public void GetAll()
        {
            Console.WriteLine("All customers are listed.");

        }

        public void Log_Text()
        {
            Console.WriteLine($"{DateTime.Now} The customer is registered.");
     
        }





    }
}
