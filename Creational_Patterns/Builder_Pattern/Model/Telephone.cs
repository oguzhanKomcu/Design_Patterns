using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Model
{
    public class Telephone
    {


        string model;
        string oS;
        string ınternal_Memory;
        string camera_MP;
        string price;

        public string Model { get; set; }
        public string OS { get; set; }
        public string Internal_Memory { get; set; }
        public string Camera_MP { get; set; }
        public string Price { get; set; }



        //With the help of the constructor method,
        //we can quickly assign a value to our object created from our class.
        //However, we can confuse them because there are too many value assignments.
        //Let's not forget that other teammates may work in our project,
        //so they may not know the parameter assignment order of our constructor method.
        //This may cause problems in data transfer.
        //Also, this kind of writing causes a lot of code.


        public Telephone(string brand, string oS, string ınternal_Memory, string camera_MP, string price)
        {
            Model = brand;
            OS = oS;
            Internal_Memory = ınternal_Memory;
            Camera_MP = camera_MP;
            Price = price;
        }



        public Telephone()
        {

        }

       




    }
}
