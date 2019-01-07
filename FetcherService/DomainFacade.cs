namespace PodcastApp.FetcherService
{
    using System.Threading.Tasks;
    using PodcastApp.FetcherService.Managers;
    using PodcastApp.FetcherService.Managers.Models;
    using PodcastApp.FetcherService.Managers.ServiceLocators;

    public sealed class DomainFacade
    {
        private readonly ServiceLocatorBase _serviceLocator;
        private SearchManager _searchManager;
        private EpisodeManager _episodeManager;

        private SearchManager SearchManager
        {
            get { return _searchManager ?? (_searchManager = _serviceLocator.CreateSearchManager()); }
        }

        private EpisodeManager EpisodeManager
        {
            get { return _episodeManager ?? (_episodeManager = _serviceLocator.CreateEpisodeManager()); }
        }

        public DomainFacade() : this(new ServiceLocator())
        {
        }

        internal DomainFacade(ServiceLocatorBase serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public async Task<ResponsePodcastSearch> FindPodcasts(RequestPodcastSearch requestPodcastSearch)
        {
            return await SearchManager.FindPodcasts(requestPodcastSearch);
        }

        public async Task<ResponsePodcastEpisodes> GetEpisodes(RequestPodcastEpisodes requestPodcastEpisodes)
        {
            return await EpisodeManager.GetEpisodes(requestPodcastEpisodes);
        }
    }
}