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

            Console.Write("\nEnter the First Name: ");
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

            return contactNew;
        }

        public void AddMultipleContacts()
        {
            Console.WriteLine("\nEnter the number of contacts you want to add ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < inputNumber; i++)
            {
                Contacts contact = AddContacts();
                contactList.Add(contact);
            }
            Console.WriteLine("\nThe added contacts are: ");
            DisplayContacts();
        }

        public void EditContacts()
        {
            int index = FindContact();
            if (index == -1)
            {
                Console.WriteLine("\nContact with the given name not found");
                return;
            }
            Console.WriteLine("\nContact matched! Please enter the new details of the contact");
            Contacts updatedContact = AddContacts();
            contactList[index] = updatedContact;
            Console.WriteLine("\nThe contact has been successfully updated.");
            Console.WriteLine("\nThe new updated contact is:");
            DisplayContacts();
        }

        public int FindContact()
        {
            Console.Write("\nPlease enter the first name of contact: ");
            string inputName = Console.ReadLine();
            inputName = inputName.ToLower();
            foreach (Contacts contact in contactList)
            {
                if(inputName.Equals(contact.firstName.ToLower()))
                {
                    return contactList.IndexOf(contact);
                }
            }
            return -1;
        }

        public void DeleteContact()
        {
            int index = FindContact();
            if(index == -1)
            {
                Console.WriteLine("\nContact with the given name not found");
                return;
            }
            contactList.RemoveAt(index);
            Console.WriteLine("\nThe contact has been successfully deleted.");
            Console.WriteLine("\nThe new updated contact is:");
            DisplayContacts();
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
