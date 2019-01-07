namespace PodcastApp.FetcherService.Managers.Gateways
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using PodcastApp.FetcherService.Managers.Models;
    using PodcastApp.FetcherService.Managers.Gateways.EpisodeMappers;

    internal sealed class EpisodeParserGateway : EpisodeBaseGateway
    {
        protected override async Task<ResponsePodcastEpisodes> GetEpisodesCore(RequestPodcastEpisodes requestPodcastEpisodes)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, requestPodcastEpisodes.Url);
            var response = await httpClient.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();

            AtomMapper.ParseAtomXml(content);

            return new ResponsePodcastEpisodes();
        }
    }
}