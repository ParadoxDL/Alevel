namespace Models
{
    internal class Fridge : ElecticalDevices
    {
        public string Size { get; set; }

        public Fridge(string name, double energyWaste, string size) : base(name, energyWaste)
        {
            Size = size;
        }
    }
}
