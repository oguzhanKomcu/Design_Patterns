using Factory_Method_Pattern.LAB.Concrete;
using Factory_Method_Pattern.LAB.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern.LAB
{
    public class FurnitureCreator
    {

        public  IFurniture Factory_Method(string materyal) 
        {
           switch (materyal)
           {
                case "Masif":
                    return new Table();
                case "mdflam":
                    return new Cupboard();
                case "suntalam":

                    return new Cupboard();
                default:
                    return null;
           }
            

        }



    }
}
