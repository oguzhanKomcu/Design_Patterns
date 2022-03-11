using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Design_Pattern
{


    /// <summary>
    /// Contact iterator class
    /// </summary>
    public class Contact_Iterator : Iterator<Contact>
    {

        private ContactTransporter _contactTransporter;

        public Contact_Iterator(ContactTransporter contactTransporter)
        {
            this._contactTransporter = contactTransporter;
        }

        //The main point of the algorithm that manages the transition from one
        //item to another is to keep the active index value of the collection in memory:
        private int Index = 0;

        public Contact CurrentItem { get; private set; }

        public bool Next()
        {
            if (Index < _contactTransporter.Number_of_Contacts)
            {
                CurrentItem = _contactTransporter.All_Communications[Index++];
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
