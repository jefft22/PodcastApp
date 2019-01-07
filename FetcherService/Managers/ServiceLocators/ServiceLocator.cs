using PodcastApp.FetcherService.Managers.Gateways;

namespace PodcastApp.FetcherService.Managers.ServiceLocators
{
    internal sealed class ServiceLocator : ServiceLocatorBase
    {
        protected override SearchManager CreateSearchManagerCore()
        {
            return new SearchManager(this);
        }

        protected override EpisodeManager CreateEpisodeManagerCore()
        {
            return new EpisodeManager(this);
        }

        protected override SearchBaseGateway CreateSearchGatewayCore()
        {
            return new SearchGpodderGateway();
        }

        protected override EpisodeBaseGateway CreateEpisodeGatewayCore()
        {
            return new EpisodeParserGateway();
        }
    }
}