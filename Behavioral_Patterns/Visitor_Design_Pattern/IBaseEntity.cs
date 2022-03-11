using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Design_Pattern
{

    //The 'BaseEntity' abstract class
    public interface IBaseEntity
    {

        //When I add a member or method to my interface, I have to process it in subclasses.
        //This becomes mandatory in every class that uses or does not use it.
        //This will be a move against design principles.

        void Accept(IVisitor visitor);
    }
}
