using AddressBook;
using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!");
            AddressBookMain addressBookSystem = new AddressBookMain();
            addressBookSystem.AddContact();
            addressBookSystem.DisplayContact();


        }


    }
}
