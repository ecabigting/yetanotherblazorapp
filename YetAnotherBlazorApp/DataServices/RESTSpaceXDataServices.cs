using System.Net.Http.Json;
using YetAnotherBlazorApp.Dtos;

namespace YetAnotherBlazorApp.DataServices
{
    public class RESTSpaceXDataServices : ISpaceXDataServices
    {
        public readonly HttpClient HttpC;
        public RESTSpaceXDataServices(HttpClient _httpC)
        {
            HttpC = _httpC;
        }
        public async Task<LaunchDto[]> GetAllLaunches()
        {
           return await HttpC.GetFromJsonAsync<LaunchDto[]>("/rest/launches?limit=20&order=desc");
        }
    }
}