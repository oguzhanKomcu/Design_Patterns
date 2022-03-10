using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Design_Pattern
{
    public class Keyboard : Equipment
    {
        // Concrete FlyWeight
        public Keyboard()
        {
            //I set intrinsic values. These members came from the ancestral class.

            Brand = "Arteck";
            Color = "Black";
            Connectivity_Technology = "Bluetooth";
        }

        public override void Add()
        {
            Console.WriteLine("The keyboard has been added to your cart.");
        }


    }
}
