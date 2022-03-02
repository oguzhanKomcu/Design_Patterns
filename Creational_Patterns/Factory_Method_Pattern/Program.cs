using Factory_Method_Pattern.LAB;
using Factory_Method_Pattern.LAB.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FurnitureCreator creator = new FurnitureCreator();

            IFurniture product = creator.Factory_Method("mdflam");
           
            Console.WriteLine($"Product sizes : {product.Dimensions()}");
            Console.ReadKey();






        }
    }
}
