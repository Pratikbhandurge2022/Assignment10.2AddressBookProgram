using System;

namespace AddressBookProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome To Address Book Program!");
            //CreateContacts createContacts = new CreateContacts();
            //createContacts.CreateContact();

            // Console.WriteLine("Add New Contacts Program");
            // AddNewContacts addNewCon = new AddNewContacts();
            // addNewCon.addNewContacts();

            //Console.WriteLine("Update Existing Contact Program");
            //UpdateExistingContact update = new UpdateExistingContact();
            //update.UpdateContact();

            //Console.WriteLine("Delete a Contact Program");
            //DeleteContact deleteContact = new DeleteContact();
            //deleteContact.ContactDelete();
            //Console.ReadKey();

            //Console.WriteLine("Welcome to Address Book Program in AddressBookMain class on  Branch UC5");
            //Console.WriteLine("Enter first name");
            //String firstName = Console.ReadLine();
            //AddressBook.SetAddress();


            Console.WriteLine("Enter first name");
            String firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            String lastName = Console.ReadLine();

            Console.WriteLine("Enter address");
            String address = Console.ReadLine();

            Console.WriteLine("Enter city");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state");
            String state = Console.ReadLine();

            Console.WriteLine("enter zip");
            long zip = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter phone number");
            long phNo = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter email");
            String email = Console.ReadLine();

            AddressBook addressBook = new AddressBook(firstName, lastName, address, city, state, zip, phNo, email);
        }
    }
}