namespace PodcastApp.FetcherService.Managers.Gateways
{
    using System.Threading.Tasks;
    using PodcastApp.FetcherService.Managers.Models;

    internal abstract class EpisodeBaseGateway
    {
        public async Task<ResponsePodcastEpisodes> GetEpisodes(RequestPodcastEpisodes requestPodcastEpisodes)
        {
            return await GetEpisodesCore(requestPodcastEpisodes);
        }

        protected abstract Task<ResponsePodcastEpisodes> GetEpisodesCore(RequestPodcastEpisodes requestPodcastEpisodes);
    }
}