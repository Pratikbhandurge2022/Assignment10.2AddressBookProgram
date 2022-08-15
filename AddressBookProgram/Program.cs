using System;

namespace AddressBookProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program!");
            CreateContacts createContacts = new CreateContacts();
            createContacts.CreateContact();
        }
    }
}