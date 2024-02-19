using Entities;

namespace Repositories
{
    internal class ContactsRepository
    {
        public static List<ContactEntity> GetContacts()
        {
            return new List<ContactEntity>
            {
                new ContactEntity { Id = 1, Name = "Helen", Age = 25 },
                new ContactEntity { Id = 2, Name = "Jane", Age = 30 },
                new ContactEntity { Id = 3, Name = "Bob", Age = 22 },
                new ContactEntity { Id = 4, Name = "Alice", Age = 28 },
                new ContactEntity { Id = 5, Name = "Gale", Age = 31 },
                new ContactEntity { Id = 6, Name = "Alex", Age = 21 }
            };
        }
    }
}
