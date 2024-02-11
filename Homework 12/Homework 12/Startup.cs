using Services;
using Services.Abstractions;

namespace Homework_12
{
    internal class Startup
    {
        public void Start()
        {
            IContactsService contactsManager = new ContactsService();

            contactsManager.AddContactsFromRepository();

            Console.WriteLine("\nContacts:");

            contactsManager.ShowContactsByAlphabet();

            contactsManager.ShowContactsByDigit();
        }
    }
    
}
