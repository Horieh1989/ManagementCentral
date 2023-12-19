using ManagementCentral.Client.services;
using Microsoft.AspNetCore.Components;
using ManagementCentral.Client.Shared;
using ManagementCentral.Shared.Domain;

namespace ManagementCentral.Client.Pages
{
    public partial class DeviceView
    {
        [Inject]
        public IDeviceDataService DeviceDataService { get; set; }

        [Parameter]
        public string DeviceId { get; set; }
        public Device Device { get; set; }

       protected override void OnInitialized()
        {

            Device = DeviceDataService.GetDevice(int.Parse(DeviceId));
            base.OnInitialized();

        }

    }
}
