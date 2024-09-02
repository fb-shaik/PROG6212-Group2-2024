using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Contact_Management_System___Index___Overload
{
    public class ContactList
    {
        private List<Contact> contacts = new List<Contact>();

        // Indexer to access contacts by index
        public Contact this[int index]
        {
            get { return contacts[index]; }
            set { contacts[index] = value; }
        }

        // Method to add a contact
        public void Add(Contact contact)
        {
            contacts.Add(contact);
        }

        // Method to remove a contact
        public bool Remove(Contact contact)
        {
            return contacts.Remove(contact);
        }
    }

}
