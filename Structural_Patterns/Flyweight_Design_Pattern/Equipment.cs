using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Design_Pattern
{
    // FlyWeight Class
    public abstract class Equipment
    {

        //Here I have determined my common properties that I will use in other classes.

        protected string Brand { get; set; }    
        protected string Color { get; set; } 
        protected string Connectivity_Technology { get; set; }

        public abstract void Add();


    }
}
