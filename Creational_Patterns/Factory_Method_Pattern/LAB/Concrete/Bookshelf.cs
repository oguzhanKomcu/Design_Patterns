using Factory_Method_Pattern.LAB.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern.LAB.Concrete
{
    public class Bookshelf : IFurniture
    {
        public string Colour()
        {
            return "White";
        }

        public string Dimensions()
        {
            return "72cm x 109cm x 34 cm ";
        }

        public string Material_Type()
        {
            return "suntalam";
        }
    }
}
