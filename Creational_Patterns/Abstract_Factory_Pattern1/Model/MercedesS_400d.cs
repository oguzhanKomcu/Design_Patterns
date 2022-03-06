using Abstract_Factory_Pattern1.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern1.Model
{
    public class MercedesS_400d : ICar
    {
        public void GetCar()
        {
            Console.WriteLine("The MercedesS_400d model was created.");
        }
    }
}
