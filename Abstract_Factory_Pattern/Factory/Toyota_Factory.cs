using Abstract_Factory_Pattern.FactoryInterface;
using Abstract_Factory_Pattern.Model;
using Abstract_Factory_Pattern.ModelInterface;
using Abstract_Factory_Pattern.Speed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern.Factory
{
    public class Toyota_Factory : ICarFactory
    {

        public ICar GetCar(ModelType modelType)
        {

            switch (modelType)
            {
                case ModelType.ToyotaYaris:
                    return new Toyota_Yaris();
                case ModelType.ToyotaCorolla:
                    return new Toyota_Corolla();
                default:
                    throw new Exception("The car model you are looking for does not exist.");


            }



        }

        public ISpeed GetSpeed(ModelType modelType)
        {
            switch (modelType)
            {
             
                case ModelType.ToyotaCorolla:
                    return new Toyota_Corolla_MaximumSpeed();
                case ModelType.ToyotaYaris:
                    return new Toyota_Yaris_MaximumSpeed();

                default:
                    throw new Exception("The maximum speed limit was not found for the car you searched for.");
            }
        }
    }
}
