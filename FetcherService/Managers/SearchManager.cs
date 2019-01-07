namespace PodcastApp.FetcherService.Managers
{
    using System.Threading.Tasks;
    using PodcastApp.FetcherService.Managers.Gateways;
    using PodcastApp.FetcherService.Managers.Models;
    using PodcastApp.FetcherService.Managers.ServiceLocators;

    internal sealed class SearchManager
    {
        private ServiceLocatorBase _serviceLocator;
        private SearchBaseGateway _searchGateway;

        private SearchBaseGateway SearchGateway
        {
            get
            {
                return _searchGateway ?? (_searchGateway = _serviceLocator.CreateSearchGateway());
            }
        }

        public SearchManager(ServiceLocatorBase serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public async Task<ResponsePodcastSearch> FindPodcasts(RequestPodcastSearch requestPodcastSearch)
        {
            return await SearchGateway.FindPodcasts(requestPodcastSearch);
        }
    }
}