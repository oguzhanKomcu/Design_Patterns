using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Design_Pattern.Classes;

namespace Visitor_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products();
            products.Name = "MSI";  
            Categories categories = new Categories();
            categories.Name = "Tecnology";
            products.Accept(new GetPriceVisitor());
            categories.Accept(new GetIdVisitor());   


            //By writing other visitor classes like this,
            //we can make new methods executable without changing our class.



            Console.ReadLine();
        }
    }
}
