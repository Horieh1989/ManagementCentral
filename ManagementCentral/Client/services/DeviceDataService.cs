using ManagementCentral.Client.component;
using ManagementCentral.Shared.Domain;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ManagementCentral.Client.services;

public class DeviceDataService : IDeviceDataService
{
    public static List<Device> DeviceList { get; set; } = new List<Device>();
    public DeviceDataService()
    {
        DeviceList.Add(new Device() { DeviceId = 1, Location = Location.Sweden, Date = DateTime.Now, DeviceType = "Sensor", Status = Status.online });
        DeviceList.Add(new Device() { DeviceId = 2, Location = Location.Sweden, Date = DateTime.Now, DeviceType = "Server", Status = Status.online });
        DeviceList.Add(new Device() { DeviceId = 3, Location = Location.England, Date = DateTime.Now, DeviceType = "Sensor", Status = Status.offline });
        DeviceList.Add(new Device() { DeviceId = 4, Location = Location.England, Date = DateTime.Now, DeviceType = "Server", Status = Status.offline });
    }

    public List<Device> GetDevices()
    {
        return DeviceList;
    }

    public Device GetDevice(int Id)
    {
        return DeviceList.FirstOrDefault(x => x.DeviceId == Id);

    }

    public void DeleteDevice(int Id)
    {
        var Device = DeviceList.FirstOrDefault(c => c.DeviceId == Id);
        if (Device! == null)
        {
            DeviceList.Remove(Device);
        }
    }

    public void UpdateDevice(Device updatedDevice)
    {
        var Device = DeviceList.FirstOrDefault(d => d.DeviceId == updatedDevice.DeviceId);
        if (Device! == null)
        {
            Device.Location = updatedDevice.Location;
            Device.Date = updatedDevice.Date;
            Device.Status = updatedDevice.Status;
            Device.DeviceType = updatedDevice.DeviceType;
        }
    }
    public void AddDevice(Device Device)// I should ask
    {
      Random rnd= new Random();
      Device.DeviceId = rnd.Next(100000);
      DeviceList.Add(Device);
    }
}




