using Builder_Pattern.Builder;
using Builder_Pattern.Interface;
using Builder_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //This is how we can do it while assigning values ​​to our object.
            //Normally, when I wanted to do it using a constructor method,
            //I could do it, but with the pattern I applied, the parameter order does not matter.
            //I assign values ​​to my incoming method according to what I want.
            //By using this pattern I prevent errors that may occur when implementing my constructor methods.

            IBuilder samsung = new TelephoneBuilder()
                .Set_Model("SamsungGalaxyS10")
                .Set_Price("600")
                .Set_Os("iOS")
                .Set_Camera_MP("48 MP")
                .SeT_Internal_Memory("64");

            Console.ReadKey();


         


        }
    }
}
