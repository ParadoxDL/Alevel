namespace Models
{
    class ElecticalDevices
    {
        public string Name { get; set; }
        public double EnergyWaste { get; set; }

        public ElecticalDevices(string name, double energyWaste)
        {
            Name = name;
            EnergyWaste = energyWaste;
        }
    }
}
