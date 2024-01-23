using Services;

namespace Models
{
    class Tomato : Vegetables
    {
        public string Color { get; set; }

        public Tomato(string name, double calories, string color) : base(name, calories)
        {
            Color = color;
        }
    }
}
