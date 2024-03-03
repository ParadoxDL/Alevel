namespace Models
{
    public class Contact
    {
        public Contact(string name, int phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public string Name { get; set; }
        public int PhoneNumber { get; set; }
    }
}
