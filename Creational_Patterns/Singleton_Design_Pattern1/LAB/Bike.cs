using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern1.LAB
{
    public class Bike
    {
        private Bike()
        {

        }

        private static Bike _bikeobject;


        //We can apply the Singleton Design Pattern by using the get block of our Static property.
        public static Bike BikeObject
        {

            get
            {
                if (_bikeobject == null)
                {
                    _bikeobject = new Bike();
                }

                return _bikeobject;
            }
            private set { }


        }

        public string BikeDrive()
        {
            return "Bike going";
        }

    }
}
