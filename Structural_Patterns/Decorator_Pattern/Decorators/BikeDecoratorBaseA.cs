using Decorator_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorators
{
    public abstract class BikeDecoratorBase : IAdditional_Feature
    {
        //Thanks to the class I created, I can now add new extensions and methods to my object. In this way, I never change the main state of my object.

        internal IAdditional_Feature _bike;
        public BikeDecoratorBase(IAdditional_Feature bike)
        {
            _bike = bike;
        }
        public virtual  void AddDescription(string desc)
        {
            _bike.AddDescription(desc);
        }

        public void AddPrice(decimal price)
        {
            _bike.AddPrice(price);
        }

        public virtual void PrintDetail()
        {
            _bike.PrintDetail();
        }
    }
}
