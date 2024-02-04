namespace Models
{
    class ElecticalDevices
    {
        public string Name { get; set; }
        public double EnergyWaste { get; set; }
        public int Id { get; set; }

        public ElecticalDevices(string name, double energyWaste, int id)
        {
            Name = name;
            EnergyWaste = energyWaste;
            Id = id;
        }
    }
}