namespace Entities
{
    internal class ToasterEntity : ElecticalDevicesEntity
    {
        public string Price { get; set; }

        public ToasterEntity(string name, double energyWaste, string price) : base(name, energyWaste)
        {
            Price = price;
        }
    }
}
