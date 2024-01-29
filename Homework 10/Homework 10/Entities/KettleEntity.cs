namespace Entities
{
    internal class KettleEntity : ElecticalDevicesEntity
    {
        public string Color { get; set; }

        public KettleEntity(string name, double energyWaste, string color) : base(name, energyWaste)
        {
            Color = color;
        }
    }
}
