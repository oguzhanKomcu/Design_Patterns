using Factory_Method_Pattern.LAB.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern.LAB.Concrete
{
    public class Cupboard : IFurniture
    {
        public string Colour()
        {
            return "Pure White";
        }

        public string Dimensions()
        {
            return "140cm x 215cm x 54 cm ";
        }

        public string Material_Type()
        {
            return "mdflam";
        }
    }
}
