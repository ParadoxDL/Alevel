using Entities;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class LinqService
    {
        public static void FirstOrDefaultTest(List<ContactEntity> contacts)
        {
            Console.WriteLine("FirstOrDefault example:");
            var firstContact = contacts.FirstOrDefault();
            Console.WriteLine($"First contact: {firstContact.Name}");
        }
        public static void WhereTest(List<ContactEntity> contacts)
        {
            Console.WriteLine("\nWhere example:");
            var adults = contacts.Where(c => c.Age >= 25);
            Console.WriteLine("People after 25:");
            foreach (var adult in adults)
            {
                Console.WriteLine($"{adult.Name}, Age: {adult.Age}");
            }
        }

        public static void SelectTest(List<ContactEntity> contacts)
        {
            Console.WriteLine("\nSelect example:");
            var contactNames = contacts.Select(c => c.Name);
            Console.WriteLine("Contact names:");
            foreach (var name in contactNames)
            {
                Console.WriteLine(name);
            }
        }

        public static void OrderByTest(List<ContactEntity> contacts)
        {
            Console.WriteLine("\nOrderBy example:");
            var orderedContacts = contacts.OrderBy(c => c.Age);
            Console.WriteLine("Contacts ordered by age:");
            foreach (var contact in orderedContacts)
            {
                Console.WriteLine($"{contact.Name}, Age: {contact.Age}");
            }
        }

        public static void SkipTest(List<ContactEntity> contacts)
        {
            Console.WriteLine("\nSkip example:");
            var skippedContacts = contacts.Skip(2);
            Console.WriteLine("Contacts after 2 skipping:");
            foreach (var contact in skippedContacts)
            {
                Console.WriteLine($"{contact.Name}, Age: {contact.Age}");
            }
        }

        public static void CountTest(List<ContactEntity> contacts)
        {
            Console.WriteLine("\nCount example:");
            var count = contacts.Count();
            Console.WriteLine($"Total number of contacts: {count}");
        }
    }
}
