using Models;

namespace Services.Interfaces
{
    internal interface IDevicesService
    {
        void SortByEnergyWaste();
        double GetTotalEnergyWaste();
        ElectricalDevices FindDeviceById(int deviceId);
        void ShowConnectedDevices();
        void GetDeviceById();
        void ShowAllDevices();
    }
}