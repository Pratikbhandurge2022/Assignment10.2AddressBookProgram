using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    internal class AddressBook
    {
        public String firstName;
        public String lastName;
        public String address;
        public String city;
        public String state;
        public long zip;
        public long phoneNumber;
        public String email;

        static public void SetAddress()
        {

            AddressBook addressBook = new AddressBook();
            addressBook.firstName = "pratik";
            addressBook.lastName = "Bhandurge";
            addressBook.address = "W Pune";
            addressBook.city = "Pune";
            addressBook.state = "Maharashtra";
            addressBook.zip = 156644;
            addressBook.phoneNumber = 212164848;
            addressBook.email = "pratik@gmail.com";
            Console.WriteLine(addressBook.firstName);
        }
    }
}