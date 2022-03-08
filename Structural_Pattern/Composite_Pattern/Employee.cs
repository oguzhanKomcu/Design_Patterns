using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    //Component
    public abstract class Employee
    {
        //It is important that we use "protected" here, if we make it private, we cannot use it in subclasses.
        protected Position _position;
        protected  string _name;

        public Employee(string name, Position position)
        {
            _name = name;

            _position = position;   

        }
 
        public abstract void SendMessage();


    }
}
