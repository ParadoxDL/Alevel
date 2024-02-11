namespace Entities
{
    public class ContactEntity
    {
        public ContactEntity(string name, int phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public string Name { get; set; }
        public int PhoneNumber { get; set; }
    }
}
