using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern1.Prototype
{
    public interface IPrototypeStudent
    {


        IPrototypeStudent Clone();
    }
}
