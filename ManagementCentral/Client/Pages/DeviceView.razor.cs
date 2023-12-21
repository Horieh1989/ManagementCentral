using ManagementCentral.Client.services;
using Microsoft.AspNetCore.Components;
using ManagementCentral.Shared.Domain;
using ManagementCentral.Client.component;

namespace ManagementCentral.Client.Pages
{
    public partial class DeviceView
    {
        [Inject]
        public IDeviceDataService DeviceDataService { get; set; }

        [Parameter]
        public int DeviceId { get; set; }
        public Device Device { get; set; }=new Device();

       protected override void OnInitialized()
        {

            Device = DeviceDataService.GetDevice(DeviceId);
            base.OnInitialized();

        }

    }
}
