using ManagementCentral.Client.component;
using ManagementCentral.Client.services;
using ManagementCentral.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace ManagementCentral.Client.Pages
{
    public partial class DeviceDelete
    {
        [Inject]
        public IDeviceDataService DeviceDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]

        public int DeviceId { get; set; }
       
        public Device Device { get; set; }=new Device();

        protected override void OnInitialized()
        {
           
           // Device = DeviceDataService.GetDevice(  DeviceId);


        }
        protected void Delet (int DeviceId)
        {
            DeviceDataService.DeleteDevice(DeviceId);//why we dont use directly instead of delet ,deletdevice
            NavigationManager.NavigateTo($"deviceLst");
        }


    }
}
