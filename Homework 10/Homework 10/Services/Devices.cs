using Models;
using Services.Interfaces;

namespace Services
{
    internal class Devices : IDevices
    {
        private ElecticalDevices[] electicalDevices;
        private ILogger logger;

        public Devices(ElecticalDevices[] electicalDevices)
        {
            this.electicalDevices = electicalDevices;
        }

        public void GetDevicesInHome()
        {
            foreach (var electicalDevices in electicalDevices)
            {
                Console.WriteLine($"Name: {electicalDevices.Name}, Caloris: {electicalDevices.EnergyWaste}");
            }
        }

        public void SortByEnergyWaste()
        {
            Array.Sort(electicalDevices, (c1, c2) => c1.EnergyWaste.CompareTo(c2.EnergyWaste));
        }

        public ElecticalDevices GetDevicesInHomeByParameter(string parameter)
        {
            try
            {
                foreach (var electicalDevices in electicalDevices)
                {
                    if (electicalDevices.Name.Equals(parameter, StringComparison.OrdinalIgnoreCase) ||
                        (electicalDevices is Dishwasher dishwasher && dishwasher.Weight.Equals(parameter, StringComparison.OrdinalIgnoreCase)) ||
                        (electicalDevices is Fridge fridge && fridge.Size.Equals(parameter, StringComparison.OrdinalIgnoreCase)) ||
                        (electicalDevices is Kettle kettle && kettle.Color.Equals(parameter, StringComparison.OrdinalIgnoreCase)) ||
                        (electicalDevices is Microwave microwave && microwave.Firm.Equals(parameter, StringComparison.OrdinalIgnoreCase)) ||
                        (electicalDevices is Toaster toaster && toaster.Price.Equals(parameter, StringComparison.OrdinalIgnoreCase)))
                    {
                        return electicalDevices;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Log($"Error searching for devices by parameter: {ex.Message}");
            }
            return null;
        }
    }
}
