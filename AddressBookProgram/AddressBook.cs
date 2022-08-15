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
        public AddressBook(string firstName, String lastName, String address, String city, String state, long zip, long phoneNumber, String email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public AddressBook()
        {

        }

        static public void SetAddress()
        {

            AddressBook addressBook = new AddressBook();
            addressBook.firstName = "Pratik";
            addressBook.lastName = "Bhandurge";
            addressBook.address = "Vimannager Pune";
            addressBook.city = "Pune";
            addressBook.state = "Maharashtra";
            addressBook.zip = 111111;
            addressBook.phoneNumber = 9876543210;
            addressBook.email = "pratik2121@gmail.com";

        }
    }
}