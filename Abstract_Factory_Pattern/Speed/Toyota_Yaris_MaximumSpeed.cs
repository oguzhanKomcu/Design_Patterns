using Abstract_Factory_Pattern.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern.Speed
{
    public class Toyota_Yaris_MaximumSpeed : ISpeed
    {
        public void GetMaximumSpeed()
        {
            Console.WriteLine("Toyota Yaris's maximum speed is 240 km/h ");
        }
    }
}
