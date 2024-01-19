using Services;

namespace Models
{
    class ChocolateBar : Sweets
    {
        public string Type { get; set; }

        public ChocolateBar(string name, double weight, string type) : base(name, weight)
        {
            Type = type;
        }
    }
}
