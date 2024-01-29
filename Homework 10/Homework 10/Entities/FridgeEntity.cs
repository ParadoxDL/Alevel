namespace Entities
{
    internal class FridgeEntity : ElecticalDevicesEntity
    {
        public string Size { get; set; }

        public FridgeEntity(string name, double energyWaste, string size) : base(name, energyWaste)
        {
            Size = size;
        }
    }
}
