using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using YetAnotherBlazorApp;
using YetAnotherBlazorApp.Helpers;

Console.WriteLine("Yeah yeah.. its running..");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
var appSettings = builder.Configuration.GetSection(nameof(AppConfiguration)).Get<AppConfiguration>();
builder.Services.AddScoped(sp => new HttpClient());
builder.Services.AddSingleton(appSettings);
await builder.Build().RunAsync();
