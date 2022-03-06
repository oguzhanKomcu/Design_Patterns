using Abstract_Factory_Pattern.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern.Model
{
    public class Mercedes_Vito : ICar
    {
        public void GetCar()
        {
            Console.WriteLine("The Mercedes Vito model was created.");
        }
    }
}
