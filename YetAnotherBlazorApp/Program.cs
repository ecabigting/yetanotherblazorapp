using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using YetAnotherBlazorApp;
using YetAnotherBlazorApp.DataServices;
using YetAnotherBlazorApp.Helpers;

Console.WriteLine("Yeah yeah.. its running..");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
var appSettings = builder.Configuration.GetSection(nameof(AppConfiguration)).Get<AppConfiguration>();
builder.Services.AddSingleton(sp => new HttpClient());
// add the httpclient factory then map the interface and implmentaion then add the base url of the API
builder.Services.AddHttpClient<ISpaceXDataServices,RESTSpaceXDataServices>
    (spds => spds.BaseAddress = new Uri(appSettings.spaceXBaseUrl));
builder.Services.AddSingleton(appSettings);
await builder.Build().RunAsync();
