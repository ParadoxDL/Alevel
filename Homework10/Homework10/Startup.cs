using Services.Interfaces;
using Services;
using Repositories;

namespace Homework10
{
    internal class Startup
    {
        public void Start()
        {
            ILoggerService logger = new LoggerService();
            IDevicesService devices = new DevicesService(new DevicesRepository(), logger);

            Console.WriteLine("All devices:");
            devices.ShowAllDevices();

            devices.SortByEnergyWaste();
            Console.WriteLine("\nSorted devices by energy waste:");
            devices.ShowAllDevices();

            Console.WriteLine("\nConnected devices:");
            devices.ShowConnectedDevices();

            Console.WriteLine($"\nTotal energy waste: {devices.GetTotalEnergyWaste()}");

            devices.GetDeviceById();
        }
    }
}