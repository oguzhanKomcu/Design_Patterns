using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Design_Pattern
{

    // Concrete FlyWeight
    public class Headset : Equipment
    {

        public Headset()
        {

            //I set intrinsic values. These members came from the ancestral class.
            Color = "White";
            Brand = "Corsair";
            Connectivity_Technology = "Wireless";


        }

        public override void Add()
        {
            Console.WriteLine("The headset has been added to your cart.");
        }
    }
}
