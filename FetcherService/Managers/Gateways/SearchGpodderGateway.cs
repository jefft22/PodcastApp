namespace PodcastApp.FetcherService.Managers.Gateways
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using PodcastApp.FetcherService.Managers.Exceptions;
    using PodcastApp.FetcherService.Managers.Models;
    using PodcastApp.FetcherService.Managers.Models.Gpodder;

    internal sealed class SearchGpodderGateway : SearchBaseGateway
    {
        protected override async Task<ResponsePodcastSearch> FindPodcastsCore(RequestPodcastSearch requestPodcastSearch)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetSearchUrl(requestPodcastSearch.Query));
            var response = await httpClient.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            var searchResults = JsonConvert.DeserializeObject<List<GpodderPodcastSummary>>(content);

            return ParseGpodderResults(searchResults);
        }

        private string GetSearchUrl(string query)
        {
            if (query == null || query.Length == 0 || query.StartsWith(" "))
            {
                throw new FetcherServiceMissingQueryException("Invalid search query entered. Queries must be at least one character long and not start with a space.");
            }

            return "https://gpodder.net/search.json?q=" + query.Replace(" ", "+");
        }

        private ResponsePodcastSearch ParseGpodderResults(IEnumerable<GpodderPodcastSummary> results)
        {
            var response = new ResponsePodcastSearch();

            foreach( var result in results)
            {
                var summary = new PodcastSummary()
                {
                    Title = result.Title,
                    Description = result.Description,
                    Url = result.Url,
                    LogoUrl = result.LogoUrl,
                    WebsiteUrl = result.Website
                };
                response.Results.Add(summary);
            }

            return response;
        }
    }
}