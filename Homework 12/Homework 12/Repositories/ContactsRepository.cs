using Entities;
using Repositories.Abstractions;

namespace Repositories
{
    internal class ContactsRepository : IContactsRepository
    {
        private ContactEntity[] contacts;

        public ContactsRepository()
        {
            contacts = new ContactEntity[]
            {
            new ContactEntity ("B", 123456789),
            new ContactEntity ("AD", 135486412),
            new ContactEntity ("AA", 987654321),
            new ContactEntity ("AC", 135404272),
            new ContactEntity ("AB", 157432158),
            new ContactEntity ("777", 843514861),
            new ContactEntity ("112", 783218324),
            new ContactEntity ("Логінов Дмитро", 357861235)
            };
        }

        public ContactEntity[] GetAllContacts()
        {
            return contacts;
        }
    }
}
