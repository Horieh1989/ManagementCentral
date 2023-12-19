using ManagementCentral.Client.component;
using ManagementCentral.Client.services;
using ManagementCentral.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace ManagementCentral.Client.Pages
{
    public partial class DeviceDelet
    {
        [Inject]
        public IDeviceDataService DeviceDataService { get; set; }

        [parameter]

        public string DeviceId { get; set; }
        public Device Device { get; set; }

        protected override void OnInitialized()
        {

            Device = DeviceDataService.GetDevice(int.Parse(  DeviceId));


        }
        protected void Delet (string DeviceId)
        {
            DeviceDataService.DeleteDevice(int.Parse(DeviceId));//why we dont use directly instead of delet ,deletdevice
        }


    }
}
