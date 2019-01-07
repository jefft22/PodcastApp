namespace PodcastApp.FetcherService.Managers
{
    using System.Threading.Tasks;
    using PodcastApp.FetcherService.Managers.Gateways;
    using PodcastApp.FetcherService.Managers.Models;
    using PodcastApp.FetcherService.Managers.ServiceLocators;

    internal sealed class EpisodeManager
    {
        private ServiceLocatorBase _serviceLocator;
        private EpisodeBaseGateway _episodeGateway;

        private EpisodeBaseGateway EpisodeGateway
        {
            get { return _episodeGateway ?? (_episodeGateway = _serviceLocator.CreateEpisodeGateway()); }
        }

        public EpisodeManager(ServiceLocatorBase serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public async Task<ResponsePodcastEpisodes> GetEpisodes(RequestPodcastEpisodes requestPodcastEpisodes)
        {
            return await EpisodeGateway.GetEpisodes(requestPodcastEpisodes);
        }
    }
}