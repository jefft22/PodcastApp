namespace PodcastApp.FetcherService.Managers.Gateways.EpisodeMappers
{
    using System.Xml.Linq;

    public static class AtomMapper
    {
        public static string ParseAtomXml(string rawXml)
        {
            var result = XElement.Parse(rawXml);

            return "";
        }
    }
}