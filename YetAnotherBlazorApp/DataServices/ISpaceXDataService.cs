using YetAnotherBlazorApp.Dtos;

namespace YetAnotherBlazorApp.DataServices
{
    public interface ISpaceXDataServices
    {
        Task<LaunchDto[]> GetAllLaunches();
    }
}