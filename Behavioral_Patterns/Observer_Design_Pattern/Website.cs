using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Design_Pattern
{
    public class Website : IObserver
    {
        public void Update()
        {
            Console.WriteLine("The new news has been added to the website.");
        }
    }
}
