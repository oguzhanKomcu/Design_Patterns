using Abstract_Factory_Pattern1.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern1.FactoryInterface
{
    public interface ICarFactory
    {
        ICar GetCar(ModelType modelType);

        ISpeed GetSpeed(ModelType modelType);


    }
}
