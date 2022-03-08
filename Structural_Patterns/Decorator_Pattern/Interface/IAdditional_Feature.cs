using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Interface
{
    public interface IAdditional_Feature
    {
        void PrintDetail();
        
        void AddDescription(string desc);

        void AddPrice(decimal price);

    }
}
