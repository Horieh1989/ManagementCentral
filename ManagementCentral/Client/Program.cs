using ManagementCentral.Client;
using ManagementCentral.Client.services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using static System.Net.WebRequestMethods;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("ManagementCentral.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("ManagementCentral.ServerAPI"));

builder.Services.AddApiAuthorization();

var apiAddress = "https://localhost:7096";
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiAddress) });// we give the address of our Api project
builder.Services.AddSingleton<IDeviceDataService, DeviceDataService>();

await builder.Build().RunAsync();
