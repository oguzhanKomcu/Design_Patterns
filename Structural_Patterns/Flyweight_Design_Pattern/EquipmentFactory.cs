using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Design_Pattern
{
    public class EquipmentFactory
    {
        private Dictionary<Computer_Equipment, Equipment> _equipment;

        public EquipmentFactory()
        {
            _equipment = new Dictionary<Computer_Equipment, Equipment>();   
        }

        public Equipment GetEquipment(Computer_Equipment equipment1)
        {
            Equipment equipment2 = null;

            //Here I am doing my object check. If my object is created, it will return me the object created directly from the list.

            if (_equipment.ContainsKey(equipment1))
            {
                equipment2 = _equipment[equipment1];
            }
            else
            {
                if (equipment1 == Computer_Equipment.mouse)
                {
                    equipment2 = new Mouse();
                }
                else if (equipment1 == Computer_Equipment.keyboard)
                {
                    equipment2 = new Keyboard();
                }
                else if (equipment1 == Computer_Equipment.headset)
                {
                    equipment2 = new Headset();
                }


                _equipment.Add(equipment1, equipment2); 

            }

            return equipment2;

        }
            


    }
}
