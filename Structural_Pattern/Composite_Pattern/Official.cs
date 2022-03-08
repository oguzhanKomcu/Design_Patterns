using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{

    //Composite
    public class Official : EmployeeComposite
    {
        //I give the employee's share in this class.
        //It is my class that allows me to create objects as tree structures.

        List<Employee> _employee = new List<Employee>();
        public Official(string name, Position position) : base(name, position)
        {
        }

        public override void AddEmployee(Employee employee)
        {
            _employee.Add(employee);    
        }

        public override void RemoveEmployee(Employee employee)
        {
            _employee.Remove(employee); 
        }


        //"_position" and "_name" came from the superclass.
        public override void SendMessage()
        {
            Console.WriteLine($"{_position} - {_name}");
            foreach (Employee employee in _employee)
            {
                employee.SendMessage();
            }

        }
    }
}
