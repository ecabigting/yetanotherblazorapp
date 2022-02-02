using Microsoft.AspNetCore.Components;
using YetAnotherBlazorApp.DataServices;
using YetAnotherBlazorApp.Dtos;

namespace YetAnotherBlazorApp.Pages
{
    public partial class Launches
    {
        [Inject]
        ISpaceXDataServices SpaceXDS {get;set;}
        private LaunchDto[] launches;
        protected override async Task OnInitializedAsync()
        {
            launches = await SpaceXDS.GetAllLaunches();
        }
    }
}