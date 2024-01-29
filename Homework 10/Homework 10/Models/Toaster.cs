namespace Models
{
    internal class Toaster : ElecticalDevices
    {
        public string Price { get; set; }

        public Toaster(string name, double energyWaste, string price) : base(name, energyWaste)
        {
            Price = price;
        }
    }
}
