using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Design_Pattern
{
    public interface IState
    {
        //With this method, I specify the working state of the motorcycle.
        void DoAction();

    }
}
