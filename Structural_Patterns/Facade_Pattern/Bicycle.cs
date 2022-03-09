using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class Bicycle
    {
        public Bicycle(Gear_And_Chain gear_And_Chain, BicycleRim rim, BikeFrame frame)
        {
            Console.WriteLine($"Gear = {gear_And_Chain.Number_of_Gears}");
            Console.WriteLine($"Chain IndeX = {gear_And_Chain.Chain_index}");
            Console.WriteLine($"Frame Size = {frame.Size}");
            Console.WriteLine($"Rim  = {rim.Inc}");

        }

    }
}
