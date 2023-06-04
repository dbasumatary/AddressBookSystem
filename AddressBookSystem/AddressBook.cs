using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        ArrayList contactList = new ArrayList();

        public Contacts AddContacts()
        {
            Contacts contactNew = new Contacts();

            Console.Write("Enter the First Name: ");
            contactNew.firstName = Console.ReadLine();
            Console.Write("Enter the Last Name: ");
            contactNew.lastName = Console.ReadLine();
            Console.Write("Enter the City: ");
            contactNew.city = Console.ReadLine();
            Console.Write("Enter the State: ");
            contactNew.state = Console.ReadLine();
            Console.Write("Enter the Address: ");
            contactNew.address = Console.ReadLine();
            Console.Write("Enter the Zip Code: ");
            contactNew.zipcode = Console.ReadLine();
            Console.Write("Enter the Phone: ");
            contactNew.phone = Console.ReadLine();
            Console.Write("Enter the Email: ");
            contactNew.email = Console.ReadLine();

            contactList.Add(contactNew);
            return contactNew;
        }

        public void DisplayContacts()
        {
            foreach (Contacts contact in contactList)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
