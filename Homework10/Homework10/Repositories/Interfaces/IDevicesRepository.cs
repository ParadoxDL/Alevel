using Models;

namespace Repositories.Interfaces
{
    internal interface IDevicesRepository
    {
        ElectricalDevices[] GetAllDevices();
        ElectricalDevices[] GetConnectedDevices();
    }
}