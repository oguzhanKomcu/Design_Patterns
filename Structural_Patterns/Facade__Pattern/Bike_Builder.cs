using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade__Pattern
{
    public class Bike_Builder
    {
        public Bike_Builder(Gear_And_Chain gear_And_Chain, BicycleRim rim, BikeFrame frame)
        {
            Gear_And_Chain = gear_And_Chain;
            Rim = rim;
            Frame = frame;
        }

        public Gear_And_Chain Gear_And_Chain { get; set; }
        public BicycleRim Rim { get; set; }
        public BikeFrame Frame { get; set; }


        public Bicycle Create()
        {
            return new Bicycle(Gear_And_Chain, Rim, Frame);
        }


    }
}
