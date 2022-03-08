using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite__Pattern
{
    //LEAF
    public class SUB_AUTHORITY : Employee
    {
        //Although the 'SUB_AUTHORITY' class represents a developer, it still derives from the 'Employee'
        //abstract class since it is essentially an employee and provides the necessary implementations in it.

        public SUB_AUTHORITY(string name, Position position) : base(name, position)
        {
        }


        public override void SendMessage()
        {
            Console.WriteLine($"{_position}-{_name}");
        }
    }
}
