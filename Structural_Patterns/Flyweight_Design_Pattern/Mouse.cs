using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Design_Pattern
{
    // Concrete FlyWeight
    public class Mouse : Equipment
    {

        public Mouse()
        {
            //I set intrinsic values. These members came from the ancestral class.

            Color = "Graphite";
            Brand = "Logitech";
            Connectivity_Technology = "USB";
        }
        public override void Add()
        {
            Console.WriteLine("The mouse has been added to your cart.");
        }
    }
}
