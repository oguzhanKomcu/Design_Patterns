using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Design_Pattern.Classes
{
    /// <summary>
    /// ConcreteVisitor
    /// </summary>
    public class GetPriceVisitor : IVisitor
    {

        //I created my class with my method name directly.
        //By creating this guest class. I am using my guest method,
        //which I created in this class, in my concrete class,
        //without adding any particular method to my class.

        public void Visit(IBaseEntity entity)
        {
            if (entity is Products)
            {
                Console.WriteLine("From the products table, products are brought according to the price of the products.");
            }
            else if (entity is Categories)
            { 
                Console.WriteLine("Category entity has no price!!"); 
            }
            else
            { 
                Console.WriteLine("No transactions can be made on this asset.");

            }
                
        }
    }
}
