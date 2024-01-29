namespace Models
{
    internal class Kettle : ElecticalDevices
    {
        public string Color { get; set; }

        public Kettle(string name, double energyWaste, string color) : base(name, energyWaste)
        {
            Color = color;
        }
    }
}
