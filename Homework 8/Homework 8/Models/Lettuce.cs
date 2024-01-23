using Services;

namespace Models
{
    class Lettuce : Vegetables
    {
        public string Type { get; set; }

        public Lettuce(string name, double calories, string type) : base(name, calories)
        {
            Type = type;
        }
    }
}
