using Decorator_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorators
{
    public class Armored_Tyre : BikeDecoratorBase
    {

        //I'm adding additional equipment to my bike.
        //
        public Armored_Tyre(IAdditional_Feature bike) : base(bike)
        {
        }

  

        public override void PrintDetail()
        {
            base._bike.AddPrice(20M);
            base._bike.AddDescription("Armored tyre has been added to the bike.");
            base._bike.PrintDetail();
        }
    }
}
