using Decorator_Pattern.Concrete;
using Decorator_Pattern.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bike bike = new Bike();
            bike.Price = 500m;
            bike.Model = "Carraro";
            bike.Brand = "SPORTİVE 250";
            bike.AddDescription("new bike");
            Console.WriteLine(bike.Description);

            Armored_Tyre armored_Tyre = new Armored_Tyre(bike);
            armored_Tyre.PrintDetail();

            Rechargeable_Led_Headlight headlight = new Rechargeable_Led_Headlight(bike);
            headlight.PrintDetail();


            Console.ReadLine();


            //OUTPUT

           // Model: Carraro Brand: SPORTİVE 250 Current Price: 500 new bike
           //Model: Carraro Brand: SPORTİVE 250 Current Price: 520 Armored tyre has been added to the bike.
           //Model: Carraro Brand: SPORTİVE 250 Current Price: 525 Rechargeable Led Headlight has been added to the bike.




        }

    }
}
