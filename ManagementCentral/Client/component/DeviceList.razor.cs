

using ManagementCentral.Client.services;
using ManagementCentral.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace ManagementCentral.Client.component
{ 
    public partial class DeviceList
    {
      //public List<Device> DeviceLst { get; set; } = new List<Device>();

      [parameter]
       public string ExtraCaption { get; set; } = string.Empty;
       [Inject]
       public IDeviceDataService? DeviceDataService { get; set; }//I should ask
       public List<Device> DeviceLst { get; set; }

    protected override void OnInitialized()
    {

        DeviceLst = DeviceDataService.GetDevices();
        //    base.OnInitialized();
        //    DeviceLst.Add(new Device()
        //    {
        //        DeviceId = Guid.NewGuid(),
        //        Location = Location.Sweden,
        //        Date = new DateTime(),
        //        DeviceType = "DeviceType1",
        //        Status = Status.offline


        //    });
        //    DeviceLst.Add(new Device()
        //    {
        //        DeviceId = Guid.NewGuid(),
        //        Location = Location.Sweden,
        //        Date = new DateTime(),
        //        DeviceType = "DeviceType2",
        //        Status = Status.online

    }
        //    });
        //}

  }

}