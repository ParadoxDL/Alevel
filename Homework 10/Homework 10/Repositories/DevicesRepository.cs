using Repositories.Interfaces;
using Entities;

namespace Repositories
{
    internal class DevicesRepository : IDevicesRepository
    {
        private ElecticalDevicesEntity[] electicalDevicesEntity;

        public DevicesRepository(ElecticalDevicesEntity[] electicalDevicesEntity)
        {
            this.electicalDevicesEntity = electicalDevicesEntity;
        }

        public void GetConnectedDevices()
        {
            foreach (var electicalDevicesEntity in electicalDevicesEntity)
            {
                Console.WriteLine($"Name: {electicalDevicesEntity.Name}, Caloris: {electicalDevicesEntity.EnergyWaste}");
            }
        }

        public double GetTotalEnergyWaste()
        {
            double totalCalories = 0;
            foreach (var electicalDevicesEntity in electicalDevicesEntity)
            {
                totalCalories += electicalDevicesEntity.EnergyWaste;
            }
            return totalCalories;
        }
    }
}
