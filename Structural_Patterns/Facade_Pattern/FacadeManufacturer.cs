using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class FacadeManufacturer
    {
        //I created my class that will combine and create my objects.
        //In this way, I will have produced my objects from one place, without complexity.
        // Whenever the function of these systems is needed, we will have to code for a long time.
        // Therefore, it will be a more reasonable and simple task to build our Facade class,
        // which we will insert between the client and the subsystem.


        Gear_And_Chain gear_and_chain;  
        BikeFrame bike_frame;   
        BicycleRim bicycle_rim;
        Bike_Builder bike_builder;

        public FacadeManufacturer()
        {
            gear_and_chain = new Gear_And_Chain() { Chain_index = "9x9x2", Number_of_Gears = "7" };
            bike_frame = new BikeFrame() { Size = "19", Material_Type = "Aluminum" };
            bicycle_rim = new BicycleRim() { Inc = "27", Material_Type = "Aluminum" };
            bike_builder = new Bike_Builder(gear_and_chain,bicycle_rim,bike_frame);

           
        }

        public void Produce_Bicycle()
        {
            Bicycle produce = bike_builder.Create();
        }
    }
}
