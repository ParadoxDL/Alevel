namespace Entities
{
    class ElecticalDevicesEntity
    {
        public string Name { get; set; }
        public double EnergyWaste { get; set; }

        public ElecticalDevicesEntity(string name, double energyWaste)
        {
            Name = name;
            EnergyWaste = energyWaste;
        }
    }
}
