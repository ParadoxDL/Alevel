using Services;

namespace Models
{
    class Cucumber : Vegetables
    {
        public string Weight { get; set; }

        public Cucumber(string name, double calories, string weight) : base(name, calories)
        {
            Weight = weight;
        }
    }
}
