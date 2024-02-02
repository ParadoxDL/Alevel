using Models;

namespace Services.Interfaces
{
    internal interface IDevices
    {
        void GetDevicesInHome();
        void SortByEnergyWaste();
        ElecticalDevices GetDevicesInHomeByParameter(string parameter);
    }
}
