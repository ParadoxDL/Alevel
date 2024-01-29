namespace Models
{
    class Dishwasher : ElecticalDevices
    {
        public string Weight { get; set; }

        public Dishwasher(string name, double energyWaste, string weight) : base(name, energyWaste)
        {
            Weight = weight;
        }
    }
}
