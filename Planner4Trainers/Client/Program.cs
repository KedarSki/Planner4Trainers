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

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHNqVVhkVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jS35Ud0JhXX9YdHdWQg==;Mgo+DSMBPh8sVXJ0S0V+XE9AflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TdEVkWHhcdHRTQ2FYVQ==;Mgo+DSMBMAY9C3t2VVhjQlFacldJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkdjXn5ZcnBVQGVfUEA=;MTA4MzQ4NEAzMjMwMmUzMzJlMzBReDVvVXdhQm9aa1A1WTZBMVZvSU9lVzFSR2xWNnA3WXdackNhLzlMQnhjPQ==");

builder.Services.AddSyncfusionBlazor();

builder.Services.AddDateRangePicker(config =>
{
    config.ApplyLabel = "My Apply Label";
});

await builder.Build().RunAsync();