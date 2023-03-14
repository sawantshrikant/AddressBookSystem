using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        List<Contact> addressBookSystem = new List<Contact>();

        public void AddContact()
        {
            Console.WriteLine("Welcome to Address Book Program!");
            Contact contact = new Contact();
            Console.WriteLine("Enter First Name:");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address:");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City:");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State:");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter PostalCode:");
            contact.PostalCode = Console.ReadLine();
            Console.WriteLine("Enter PhoneNumber:");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            contact.Email = Console.ReadLine();
            addressBookSystem.Add(contact);
        }
        public void DisplayContact()
        {  
            foreach (var contact in addressBookSystem)
            {
                Console.WriteLine("\nDisplaying Contact Information:");
                Console.WriteLine("First Name: " + contact.FirstName);
                Console.WriteLine("Last Name: " + contact.LastName);
                Console.WriteLine("Address: " + contact.Address);
                Console.WriteLine("City: " + contact.City);
                Console.WriteLine("State: " + contact.State);
                Console.WriteLine("Postal Code: " + contact.PostalCode);
                Console.WriteLine("Phone Number: " + contact.PhoneNumber);
                Console.WriteLine("Email: " + contact.Email);
                
            }

            
        }
    }
}
