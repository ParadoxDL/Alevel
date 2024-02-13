using Models;
using Repositories.Interfaces;
using Services.Interfaces;

namespace Services
{
    internal class DevicesService : IDevicesService
    {
        private IDevicesRepository repository;
        private ILoggerService logger;

        public DevicesService(IDevicesRepository repository, ILoggerService logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public double GetTotalEnergyWaste()
        {
            logger.Log("Calculating total power consumption.");
            double totalWaste = 0;
            foreach (var connectedDevices in repository.GetConnectedDevices())
            {
                totalWaste += connectedDevices.EnergyWaste;
            }
            return totalWaste;
        }

        public void SortByEnergyWaste()
        {
            logger.Log("Sorted devices by power consumption.");
            Array.Sort(repository.GetAllDevices(), (x, y) => x.EnergyWaste.CompareTo(y.EnergyWaste));
        }

        public ElectricalDevices FindDeviceById(int deviceId)
        {
            logger.Log($"Device by ID: {deviceId}");
            return Array.Find(repository.GetAllDevices(), device => device.Id == deviceId);
        }

        public void ShowAllDevices()
        {
            logger.Log("Information about electrical devices.");
            foreach (var device in repository.GetAllDevices())
            {
                Console.WriteLine($"Id: {device.Id}, Name: {device.Name}, Energy waste: {device.EnergyWaste}");
            }
        }

        public void ShowConnectedDevices()
        {
            logger.Log("Information about electrical devices.");
            foreach (var device in repository.GetConnectedDevices())
            {
                Console.WriteLine($"Id: {device.Id}, Name: {device.Name}, Energy waste: {device.EnergyWaste}");
            }
        }

        public void GetDeviceById()
        {
            logger.Log("Device search by ID.");
            Console.Write("\nEnter id to find: ");
            if (int.TryParse(Console.ReadLine(), out int searchId))
            {
                Console.WriteLine($"\nFind device by id: {searchId}:");
                ElectricalDevices foundDevice = FindDeviceById(searchId);
                if (foundDevice != null)
                {
                    Console.WriteLine($"Founded: {foundDevice.Name}, Energy waste: {foundDevice.EnergyWaste}");
                }
                else
                {
                    Console.WriteLine($"Device with {searchId} id not found.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect id. Enter integer.");
            }
        }
    }
}