using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade__Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //As you can see, we have processed the operations that we can describe as
            //complex and detailed in subsystems in the Facade class in an organized manner,
            //and we have performed our operations on the right by using this simplified interface on the client.

            FacadeManufacturer producer = new FacadeManufacturer();
            producer.Produce_Bicycle();

            Console.ReadLine();
        }
    }
}
