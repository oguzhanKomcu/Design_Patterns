using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Design_Pattern
{
    public class ContactTransporter : ITransporter<Contact>
    {
        //"Contact" collection
        public List<Contact> All_Communications { get; } = new List<Contact>();

        //Add contact to collection
        public void AddContact(Contact kategori)
        {
            All_Communications.Add(kategori);
        }

        public int Number_of_Contacts { get => All_Communications.Count; }

        //Iterator of the collection
        public Iterator<Contact> CreateIterator()
        {
             return new Contact_Iterator(this);
        }
    }
}
