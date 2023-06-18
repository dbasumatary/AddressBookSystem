namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook addressBook = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nPLease enter the choices");
                Console.WriteLine("\n1. Add New Contacts\n2. Display contacts\n3. Edit Contacts\n4. Delete Contact\n5. FileIO\n6. Exit");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            addressBook.AddMultipleContacts();
                            break;
                        case 2:
                            addressBook.DisplayContacts();
                            break;
                        case 3:
                            addressBook.EditContacts();
                            break;
                        case 4:
                            addressBook.DeleteContact();
                            break;
                        case 5:
                            Console.WriteLine("Enter your choice\n");
                            Console.WriteLine("\n1. Read from Json File\n2. Write into Json File");

                            int inputChoice = Convert.ToInt32(Console.ReadLine());
                            switch (inputChoice)
                            {
                                case 1:
                                    addressBook.ReadFileJson();
                                    break;
                                case 2:
                                    addressBook.WriteFileJson();
                                    break;
                                default:
                                    Console.WriteLine("Please enter the specified choice");
                                    break;
                            }
                            break;
                        case 6:
                            flag = false;
                            break;
                    }
                }

                catch (CustomException e)
                {
                    Console.WriteLine("Custom exception caught: " + e.Message);
                }
                
                catch (Exception e)
                {
                    Console.WriteLine("General exception caught: " + e.Message);
                }
            }
        }
    }
}