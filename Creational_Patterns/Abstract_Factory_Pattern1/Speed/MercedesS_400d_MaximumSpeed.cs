using Abstract_Factory_Pattern1.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern1.Speed
{
    public class MercedesS_400d_MaximumSpeed : ISpeed
    {
        public void GetMaximumSpeed()
        {
            Console.WriteLine(" MercedesS 400d's maximum speed is 240 km/h ");

        }
    }
}
