namespace PodcastApp.FetcherService.Managers.Gateways
{
    using System.Threading.Tasks;
    using PodcastApp.FetcherService.Managers.Models;

    internal abstract class SearchBaseGateway
    {
        public async Task<ResponsePodcastSearch> FindPodcasts(RequestPodcastSearch requestPodcastSearch)
        {
            return await FindPodcastsCore(requestPodcastSearch);
        }

        protected abstract Task<ResponsePodcastSearch> FindPodcastsCore(RequestPodcastSearch requestPodcastSearch);
    }
}