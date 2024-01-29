namespace Entities
{
    class DishwasherEntity : ElecticalDevicesEntity
    {
        public string Weight { get; set; }

        public DishwasherEntity(string name, double energyWaste, string weight) : base(name, energyWaste)
        {
            Weight = weight;
        }
    }
}
