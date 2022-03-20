using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Design_Pattern
{
    public class MobilApp : IObserver
    {
        public void Update()
        {
            Console.WriteLine("New news has been added to the application.");
        }
    }
}
