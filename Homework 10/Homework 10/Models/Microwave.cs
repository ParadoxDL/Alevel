namespace Models
{
    internal class Microwave : ElecticalDevices
    {
        public string Firm { get; set; }

        public Microwave(string name, double energyWaste, string firm) : base(name, energyWaste)
        {
            Firm = firm;
        }
    }
}
