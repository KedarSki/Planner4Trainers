using Client;
using Client.Services;
using Client.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using BlazorDateRangePicker;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7136") });
builder.Services.AddScoped<IExerciseTypeService, ExerciseTypeService>();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddDateRangePicker(config =>
{
    config.ApplyLabel = "My Apply Label";
});

Syncfusion.Licensing.SyncfusionLicenseProvider
    .RegisterLicense("NzE0MjgyQDMyMzAyZTMyMmUzMEtacWtSVmRwc2xKNS9ValM4SHNrK3AwTUtzOG9Tb0lNUlowVFllYWJMZWs9");

await builder.Build().RunAsync();