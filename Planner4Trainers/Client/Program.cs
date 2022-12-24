using Client;
using Client.Services;
using Client.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using BlazorDateRangePicker;
using Blazored.LocalStorage;
using Client.Providers;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7136") });

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<AppAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(provider 
    => provider.GetRequiredService<AppAuthenticationStateProvider>());


builder.Services.AddScoped<IExerciseTypeService, ExerciseTypeService>();
builder.Services.AddScoped<IPlannerService, PlannerService>();

builder.Services.AddSyncfusionBlazor();

builder.Services.AddDateRangePicker(config =>
{
    config.ApplyLabel = "My Apply Label";
});

Syncfusion.Licensing.SyncfusionLicenseProvider
    .RegisterLicense("NzE0MjgyQDMyMzAyZTMyMmUzMEtacWtSVmRwc2xKNS9ValM4SHNrK3AwTUtzOG9Tb0lNUlowVFllYWJMZWs9");

await builder.Build().RunAsync();