using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Design_Pattern.Classes
{
    public class GetIdVisitor : IVisitor
    {
        //I created my class with my method name directly.
        //By creating this guest class. I am using my guest method,
        //which I created in this class, in my concrete class,
        //without adding any particular method to my class.

        public void Visit(IBaseEntity entity)
        {
            if (entity is Products)
            {
                Console.WriteLine("The product is brought according to its ID.");
            }
            else if (entity is Categories)
            {
                Console.WriteLine("The category is brought according to its ID.!!");
            }
            else
            {
                Console.WriteLine("No transactions can be made on this asset.");

            }
        }
    }
}
