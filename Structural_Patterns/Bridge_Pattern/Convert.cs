using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public abstract class Convert
    {
        IRun _run;

        //Here I have created my abstract class which acts as a bridge to set my browser to work on all platforms.
        //Objects cannot be produced from abstract classes. We use the constructor method to get the object we want to receive with the help of subclass.
        public Convert(IRun run)
        {
            _run = run;
        }

        //I run the desired OS with this method.
        //In this method, it will be run with the command taken from my subclass.
        public virtual void ConvertRun()
        {
            _run.BrowserRun();  
        }



    }
}
