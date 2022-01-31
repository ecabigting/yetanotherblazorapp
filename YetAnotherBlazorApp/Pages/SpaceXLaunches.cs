using YetAnotherBlazorApp.Dtos;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using YetAnotherBlazorApp.Helpers;

namespace YetAnotherBlazorApp.Pages 
{
    public partial class SpaceXLaunches
    {
        [Inject]
        private HttpClient Http {get;set;}
        [Inject]
        private AppConfiguration Config {get;set;}
        private LaunchDto[]? launches;
        protected override async Task OnInitializedAsync()
        {
            Http.BaseAddress = new Uri(Config.spaceXBaseUrl);
            launches = await Http.GetFromJsonAsync<LaunchDto[]>("/rest/launches?limit=20&order=desc");
        }

    }
}