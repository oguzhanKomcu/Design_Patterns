using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Design_Pattern
{
    public interface ITransporter<T>
    {
        ////Each container contains both a collection and an iterator object.
        Iterator<T> CreateIterator();
    }
}
