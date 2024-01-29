namespace Entities
{
    internal class MicrowaveEntity : ElecticalDevicesEntity
    {
        public string Firm { get; set; }

        public MicrowaveEntity(string name, double energyWaste, string firm) : base(name, energyWaste)
        {
            Firm = firm;
        }
    }
}
