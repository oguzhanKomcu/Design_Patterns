using Abstract_Factory_Pattern1.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern1.Speed
{
    public class Toyota_Corolla_MaximumSpeed : ISpeed
    {
        public void GetMaximumSpeed()
        {
            Console.WriteLine("Toyota Corolla's maximum speed is 240 km/h ");

        }
    }
}
