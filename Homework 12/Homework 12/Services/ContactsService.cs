using Models;
using Repositories;
using Services.Abstractions;

namespace Services
{
    public class ContactsService : IContactsService
    {
        private Dictionary<char, List<Contact>> contactsByAlphabet = 
            new Dictionary<char, List<Contact>>();
        private Dictionary<char, List<Contact>> contactsByDigit = 
            new Dictionary<char, List<Contact>>();
        private ContactsRepository contactsRepository = new ContactsRepository();

        public ContactsService()
        {
            AddGroups();
        }

        public void AddGroups()
        {
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                contactsByAlphabet.Add(letter, new List<Contact>());
            }
            for (char letter = 'А'; letter <= 'Я'; letter++)
            {
                contactsByAlphabet.Add(letter, new List<Contact>());
            }
            contactsByAlphabet.Add('#', new List<Contact>());

            for (char digit = '0'; digit <= '9'; digit++)
            {
                contactsByDigit.Add(digit, new List<Contact>());
            }
        }

        public void AddContactsFromRepository()
        {
            var allContacts = contactsRepository.GetAllContacts();
            foreach (var contactEntity in allContacts)
            {
                AddContact(new Contact(contactEntity.Name, contactEntity.PhoneNumber));
            }
        }

        public void AddContact(Contact contact)
        {
            char groupKey = GetGroupKey(contact.Name);
            if (char.IsDigit(groupKey))
            {
                contactsByDigit[groupKey].Add(contact);
            }
            else
            {
                List<Contact> group;
                if (contactsByAlphabet.TryGetValue(groupKey, out group))
                {
                    group.Add(contact);
                }
            }
        }

        public char GetGroupKey(string name)
        {
            char firstChar = char.ToUpper(name[0]);
            if ((firstChar >= 'A' && firstChar <= 'Z') 
                || (firstChar >= 'a' && firstChar <= 'z') 
                || (firstChar >= 'А' && firstChar <= 'Я') 
                || (firstChar >= 'а' && firstChar <= 'я'))
            {
                return firstChar;
            }
            else if (char.IsDigit(firstChar))
            {
                return firstChar;
            }
            else
            {
                return '#';
            }
        }

        public void ShowContactsByAlphabet()
        {
            foreach (var groupedContacts in contactsByAlphabet)
            {
                if (groupedContacts.Value.Count > 0)
                {
                    Console.WriteLine($"Group {groupedContacts.Key}:");

                    var sortedContacts = groupedContacts.Value.OrderBy(contact 
                        => contact.Name);

                    foreach (var contact in sortedContacts)
                    {
                        Console.WriteLine($"  {contact.Name} - {contact.PhoneNumber}");
                    }
                }
            }
        }

        public void ShowContactsByDigit()
        {
            foreach (var groupedContacts in contactsByDigit)
            {
                if (groupedContacts.Value.Count > 0)
                {
                    Console.WriteLine($"Group {groupedContacts.Key}:");

                    var sortedContacts = groupedContacts.Value.OrderBy(contact 
                        => contact.Name);

                    foreach (var contact in sortedContacts)
                    {
                        Console.WriteLine($"  {contact.Name} - {contact.PhoneNumber}");
                    }
                }
            }
        }
    }
}
