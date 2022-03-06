using Builder_Pattern.Interface;
using Builder_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Builder
{
    public class TelephoneBuilder : IBuilder
    {

        //Using my design, I created my methods to assign values ​​within this class..


        Telephone telephone = new Telephone();

        public Telephone Build()
        {
            return telephone;
        }

        public IBuilder Set_Camera_MP(string Camera_MP)
        {
            telephone.Camera_MP = Camera_MP;
            return this;
        }

        public IBuilder SeT_Internal_Memory(string Internal_Memory)
        {
            telephone.Internal_Memory = Internal_Memory;
            return this;
        }

        public IBuilder Set_Model(string model)
        {
            telephone.Model = model;
            return this;
        }

        public IBuilder Set_Os(string Os)
        {
            telephone.OS = Os;
            return this;
        }

        public IBuilder Set_Price(string Price)
        {
            telephone.Price = Price;
            return this;
        }
    }
}
