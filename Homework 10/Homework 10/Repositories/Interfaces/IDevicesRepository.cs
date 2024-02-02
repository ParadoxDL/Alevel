namespace Repositories.Interfaces
{
    internal interface IDevicesRepository
    {
        void GetConnectedDevices();
        double GetTotalEnergyWaste();
    }
}
