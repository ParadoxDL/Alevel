using Services;

namespace Models
{
    class Lollipop : Sweets
    {
        public string Flavor { get; set; }

        public Lollipop(string name, double weight, string flavor) : base(name, weight)
        {
            Flavor = flavor;
        }
    }
}
