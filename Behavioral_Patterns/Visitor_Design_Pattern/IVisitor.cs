using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Design_Pattern
{
    //The 'Visitor' interface
    public interface IVisitor
    {

        //Here I created my common method that I will use in guest classes.
        //If we add our methods one by one to all the classes that need to be added,
        //the clarity of the code will deteriorate and it will be difficult to maintain.
        //If a change is to be made in the method,
        //the methods in all classes will need to be updated one by one.
        //We can eliminate these situations with the Visitor design pattern,
        //by writing new visitor classes for each new need and having our class use it.

        void Visit(IBaseEntity tablet);

    }
}
