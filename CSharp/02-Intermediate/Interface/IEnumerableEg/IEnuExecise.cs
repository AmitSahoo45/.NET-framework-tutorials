using System;
using System.Collections.Generic;

namespace IEnuExercise
{
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string phoneNumber)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }

        public void Call()
        {
            Console.WriteLine("Calling to {0}. Phone Number is {1}", this.Name, this.PhoneNumber);
        }
    }

    public class PhoneBook : IEnumerable<Contact>
    {
        public List<Contact> Contacts = new List<Contact>()
        {
            new Contact("Andre", "1234567890"),
            new Contact("Brenda", "2345678901"),
            new Contact("Dine", "3456789012"),
            new Contact("Sofi", "4567890123")
        };

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<Contact> GetEnumerator()
        {
            return Contacts.GetEnumerator();
        }
    }

    class Program
    {
        static public void Main(string[] args)
        {
            PhoneBook pb = new PhoneBook();

            foreach (Contact cnc in pb)
                cnc.Call();
        }
    }
};