using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite__Pattern
{
    //Component
    public abstract class EmployeeComposite : Employee
    {

        //All elements defined by the Composite design pattern have a common interface.
        //Thanks to this interface, the client code can do its job without dealing with the actual class of the object it is working on.
        protected EmployeeComposite(string name, Position position) : base(name, position)
        {
        }
        public abstract void AddEmployee(Employee employee);
        public abstract void RemoveEmployee(Employee employee);

        //Here I have a Composite abstract class that inherits from the Employee abstract class.
        //Here, methods that should normally override when inheriting from other classes should be implemented, but we did not apply them here.
        //Because abstract classes can inherit from each other, but they do not have to inherit their methods and elements.
        //Concrete that inherits from the last abstract class implemented in the classroom. He has to implement all.

    }
}
