namespace PodcastApp.FetcherService.Managers.Models
{
    using System;
    using Newtonsoft.Json;

    public sealed class PodcastSummary
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }
    }
}