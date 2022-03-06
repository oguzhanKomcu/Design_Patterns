using Abstract_Factory_Pattern1.Factory;
using Abstract_Factory_Pattern1.FactoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ICarFactory carFactory = new Toyota_Factory();
            carFactory.GetCar(ModelType.ToyotaYaris).GetCar();
            carFactory.GetSpeed(ModelType.ToyotaYaris).GetMaximumSpeed();

            Console.ReadKey();

        }
    }
}
