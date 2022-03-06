using Abstract_Factory_Pattern1.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern1.Speed
{
    public class Mercedes_VitoMaximumSpeed : ISpeed
    {
        public void GetMaximumSpeed()
        {
            Console.WriteLine("Mercedes Vito's maximum speed is 320 km/h ");
        }
    }
}
