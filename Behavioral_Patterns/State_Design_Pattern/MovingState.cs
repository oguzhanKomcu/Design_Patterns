using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Design_Pattern
{
    internal class MovingState : IState
    {
        public void DoAction()
        {
            Console.WriteLine("The motorcycle is moving.");
        }
    }
}
