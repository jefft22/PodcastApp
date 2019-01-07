namespace PodcastApp.FetcherService.Managers.ServiceLocators
{
    using PodcastApp.FetcherService.Managers.Gateways;

    internal abstract class ServiceLocatorBase
    {
        public SearchManager CreateSearchManager()
        {
            return CreateSearchManagerCore();
        }

        public EpisodeManager CreateEpisodeManager()
        {
            return CreateEpisodeManagerCore();
        }

        public SearchBaseGateway CreateSearchGateway()
        {
            return CreateSearchGatewayCore();
        }

        public EpisodeBaseGateway CreateEpisodeGateway()
        {
            return CreateEpisodeGatewayCore();
        }

        protected abstract SearchManager CreateSearchManagerCore();
        protected abstract EpisodeManager CreateEpisodeManagerCore();
        protected abstract SearchBaseGateway CreateSearchGatewayCore();
        protected abstract EpisodeBaseGateway CreateEpisodeGatewayCore();
    }
}