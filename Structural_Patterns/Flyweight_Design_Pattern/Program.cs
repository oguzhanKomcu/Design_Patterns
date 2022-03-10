using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Computer_Equipment[] equipments = { Computer_Equipment.keyboard, Computer_Equipment.mouse, Computer_Equipment.headset, Computer_Equipment.keyboard };

            //I am generating a FlyWeight Factory object.
            EquipmentFactory equipmentfactory = new EquipmentFactory();

            foreach (Computer_Equipment equipment in equipments)
            {
                Equipment eqt = equipmentfactory.GetEquipment(equipment);

                eqt.Add();


            }

            Console.ReadKey();


        }
    }
}
