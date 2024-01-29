using Services.Interfaces;
using Services;
using Models;
using Entities;
using Repositories.Interfaces;
using Repositories;

namespace Homework_10
{
    internal class Startup
    {
        public static void Start()
        {
            ElecticalDevicesEntity connectedDevices1 = new DishwasherEntity("Dishwasher", 300, "40 kg");
            ElecticalDevicesEntity connectedDevices2 = new FridgeEntity("Fridge", 500, "2 m");
            ElecticalDevicesEntity connectedDevices3 = new KettleEntity("Kettle", 50, "Red");

            ElecticalDevices devices1 = new Dishwasher("Dishwasher", 300, "40 kg");
            ElecticalDevices devices2 = new Fridge("Fridge", 500, "2 m");
            ElecticalDevices devices3 = new Kettle("Kettle", 50, "Red");
            ElecticalDevices devices4 = new Microwave("Microwave", 100, "Samsung");
            ElecticalDevices devices5 = new Toaster("Toaster", 80, "$100");

            ElecticalDevices[] devices = { devices1, devices2, devices3, devices4, devices5 };
            ElecticalDevicesEntity[] connectedDevices = { connectedDevices1, connectedDevices2, connectedDevices3 };

            IDevices DevicesInHome = new Devices(devices);
            IDevicesRepository ConnectedDevices = new DevicesRepository(connectedDevices);

            Console.WriteLine("Conected devices:");
            ConnectedDevices.GetConnectedDevices();

            Console.WriteLine($"Total energy waste: {ConnectedDevices.GetTotalEnergyWaste()}");

            Console.WriteLine("\nDevices in home:");
            DevicesInHome.GetDevicesInHome();

            DevicesInHome.SortByEnergyWaste();

            Console.WriteLine("\nSorted devices in home by energy waste:");
            DevicesInHome.GetDevicesInHome();

            Console.Write("\nEnter a parameter to search for a devices in home (for example, name, energy waste, size, price): ");
            string searchParameter = Console.ReadLine();

            ElecticalDevices foundDevicesInHome = DevicesInHome.GetDevicesInHomeByParameter(searchParameter);

            if (foundDevicesInHome != null)
            {
                Console.WriteLine($"Found devices in home: {foundDevicesInHome.Name}, energy waste: {foundDevicesInHome.EnergyWaste}");
            }
            else
            {
                Console.WriteLine($"Devices in home with the parameter {searchParameter} not found.");
            }
        }
    }
}
