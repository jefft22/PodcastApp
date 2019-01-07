namespace PodcastApp.FetcherService.Managers.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class ResponsePodcastSearch
    {
        [JsonProperty("results")]
        public List<PodcastSummary> Results { get; set; } = new List<PodcastSummary>();
    }
}