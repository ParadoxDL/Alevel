using Entities;

namespace Repositories.Abstractions
{
    internal interface IContactsRepository
    {
        ContactEntity[] GetAllContacts();
    }
}
