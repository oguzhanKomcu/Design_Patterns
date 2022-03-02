using Factory_Method_Pattern.LAB.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern.LAB.Concrete
{
    public class Table : IFurniture
    {
        public string Colour()
        {
            return "walnut";
        }

        public string Dimensions()
        {
            return "132 cm x 80 cm x 78 cm";
        }

        public string Material_Type()
        {
            return " Masif ";
        }
    }
}
