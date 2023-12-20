using ManagementCentral.Client.services;
using Microsoft.AspNetCore.Components;
using ManagementCentral.Shared.Domain;

namespace ManagementCentral.Client.Pages
{
    public partial class DeviceView
    {
        [Inject]
        public IDeviceDataService DeviceDataService { get; set; }

        [Parameter]
        public string DeviceId { get; set; }
        public Device Device { get; set; }=new Device();

       protected override void OnInitialized()
        {

            Device = DeviceDataService.GetDevice(int.Parse(DeviceId));
            base.OnInitialized();

        }

    }
}
