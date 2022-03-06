using Builder_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Interface
{
    public interface IBuilder
    {
        //I created my set methods in my interface. In this way, I can assign a value.

        IBuilder Set_Model(string model);
        IBuilder Set_Os(string Os);
        IBuilder SeT_Internal_Memory(string Internal_Memory);
        IBuilder Set_Camera_MP(string Camera_MP);
        IBuilder Set_Price(string Price);
        Telephone Build();

    }    
}
