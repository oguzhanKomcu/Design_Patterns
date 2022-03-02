using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Dizayn_Pattern.LAB
{
    public class Bike
    {
        private Bike()
        {

        }

        private static Bike _bikeobject;



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
