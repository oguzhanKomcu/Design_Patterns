using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Design_Pattern
{
    internal class OffState : IState
    {
        public void DoAction()
        {
            Console.WriteLine("The motorcycle is turned off.");
        }
    }
}
