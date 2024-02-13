using Repositories.Interfaces;
using Entities;
using Models;

namespace Repositories
{
    internal class DevicesRepository : IDevicesRepository
    {
        private ElectricalDevices[] electicalDevices;
        private ElectricalDevices[] connectedDevices;

        public DevicesRepository()
        {
            electicalDevices = new ElectricalDevices[]
            {
                new DishwasherEntity {Name = "Dishwasher", EnergyWaste = 300, Id = 1},
                new FridgeEntity { Name = "Fridge", EnergyWaste = 500,Id = 2},
                new KettleEntity { Name = "Kettle", EnergyWaste = 50, Id = 3 },
                new MicrowaveEntity { Name = "Microwave", EnergyWaste = 100, Id = 4},
                new ToasterEntity { Name = "Toaster", EnergyWaste = 80, Id =  5 }
            };

            connectedDevices = new ElectricalDevices[]
            {
                new DishwasherEntity {Name = "Dishwasher", EnergyWaste = 300, Id = 1},
                new FridgeEntity { Name = "Fridge", EnergyWaste = 500,Id = 2},
                new KettleEntity { Name = "Kettle", EnergyWaste = 50, Id = 3 }
            };
        }

        public ElectricalDevices[] GetAllDevices()
        {
            return electicalDevices;
        }

        public ElectricalDevices[] GetConnectedDevices()
        {
            return connectedDevices;
        }
    }
}