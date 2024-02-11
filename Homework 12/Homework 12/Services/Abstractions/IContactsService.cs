using Models;

namespace Services.Abstractions
{
    internal interface IContactsService
    {
        void AddGroups();
        void AddContactsFromRepository();
        void AddContact(Contact contact);
        char GetGroupKey(string name);
        void ShowContactsByAlphabet();
        void ShowContactsByDigit();

    }
}
