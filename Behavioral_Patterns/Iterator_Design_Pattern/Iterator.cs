using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Design_Pattern
{
    //The Iterator should work in every class of mine. That's why I gave the "T" type.
    public interface Iterator<T>
    {
        //The iterator should be able to return the item it is running on.
        T CurrentItem { get; }
        // With this method, skip to the next item, if any.
        bool Next();
    }
}
