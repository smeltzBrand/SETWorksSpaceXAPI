using SETWorksSpaceXAPI.Models;

namespace SETWorksSpaceXAPI.Services.Interfaces
{
    public interface ILaunchJSONService
    {
        public Task<List<Launch>> GetLaunchDataAsync();

        public Task<List<Payload>> GetPayloadRankAsync();
    }
}
