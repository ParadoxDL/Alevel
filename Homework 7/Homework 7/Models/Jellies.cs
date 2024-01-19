using Services;

namespace Models
{
    class Jelly : Sweets
    {
        public string Color { get; set; }

        public Jelly(string name, double weight, string color) : base(name, weight)
        {
            Color = color;
        }
    }
}
