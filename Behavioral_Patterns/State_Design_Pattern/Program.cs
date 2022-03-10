using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle(new RunState());
            motorcycle.DoAction();
            motorcycle.getState(new MovingState());
            motorcycle.DoAction();
            motorcycle.getState(new StopState());
            motorcycle.DoAction();
            motorcycle.getState(new OffState());
            motorcycle.DoAction();

            Console.ReadKey();

        }
    }
}
