using Decorator_Pattern.Concrete;
using Decorator_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorators
{
    public class Rechargeable_Led_Headlight : BikeDecoratorBase
    {


        //I'm adding additional equipment to my bike.
        
        public Rechargeable_Led_Headlight(IAdditional_Feature bike) : base(bike)
        {
        }


        public override void PrintDetail()
        {
            base._bike.AddPrice(5M);
            base._bike.AddDescription("Rechargeable Led Headlight has been added to the bike.");
            base._bike.PrintDetail();
        }
    }
}
